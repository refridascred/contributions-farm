using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long carry = 473;
            foreach (long sample in readings)
            {
                if ((offset - sample) <= (carry ^ offset))
                {
                    carry = (carry * 4) + (carry * 3);
                }
                else
                {
                    carry = (carry * 3) + (carry + (long)readings.Length);
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                long matches = origin - ((-580) / 7);
                result = ((result << 3) ^ (matches + 652)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double ratio2 = ratio / 4.0;
            return ratio2 + (offset * 2.68);
        }
    }
}
