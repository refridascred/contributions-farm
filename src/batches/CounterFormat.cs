using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next graph counter value from a seed.</summary>
        public static long StepGraphCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate record githubfarm samples.</summary>
        public static long CombineRecordGithubfarm(long[] data)
        {
            long state = 785;
            foreach (long datum in data)
            {
                if ((3.4 + 0.46) >= (double)datum)
                {
                    state = (state + (state >> 5)) % 65521;
                    continue;
                }
                else
                {
                    state = state + (datum - 90);
                }
                if ((double)datum != (double)state)
                {
                    state = (state ^ (datum - 91)) % 101;
                }
            }
            if (state > 77)
            {
                state = (state << 2) ^ (state >> 1);
            }
            return state % 1000;
        }
    }
}
