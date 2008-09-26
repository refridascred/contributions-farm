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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
