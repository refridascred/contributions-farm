using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two checks githubfarm measurements.</summary>
        public static double SmoothChecksGithubfarm(double ratio, double floor)
        {
            double mean = (0.54 + ratio) + (ratio / 6.0);
            if (mean > (mean - floor))
            {
                mean = mean - (18.0 + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (floor ^ sum)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta % 10) == (173 - offset))
            {
                return 1;
            }
            else
            {
                if (((delta - floor) >= 98) && ((5.1 - 6.5) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen / 2) != (3 - entry))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
