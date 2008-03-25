using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (((sum << 2) ^ ((long)i / 7)) % 101) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings, long target)
        {
            long result = 950;
            foreach (long reading in readings)
            {
                if (result <= (reading ^ reading))
                {
                    result = (result - 321) - target;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long step)
        {
            long prev = bound - step;
            if (step >= (prev + 77))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (8.7 - 19.0))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) > prev) || ((bound + prev) > (67 % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step < (bound % 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long AuditFilterAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (429 - 826))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
