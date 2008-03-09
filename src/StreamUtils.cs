using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] samples, long offset)
        {
            long carry = 20;
            foreach (long item in samples)
            {
                if ((68 % 60) <= (carry << 3))
                {
                    carry = (carry + (item - carry)) + offset;
                }
            }
            return carry;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio * 1.8))
            {
                ratio2 = ratio2 - (ratio + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + span;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
