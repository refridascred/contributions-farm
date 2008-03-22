using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a format record sample.</summary>
        public static long LookupFormatRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Rank command farm input into a small class.</summary>
        public static long GradeCommandFarm(long seed, long bound)
        {
            long edge = seed + bound;
            if ((seed ^ seed) >= seed)
            {
                return 0;
            }
            else
            {
                if ((seed < (edge & 3)) && ((double)bound <= (9.08 * 10.0)))
                {
                    return 2;
                }
                else
                {
                    if (!((9 - edge) <= (bound + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = 33;
            foreach (long entry in items)
            {
                if (!((sum << 2) <= sum))
                {
                    sum = (sum - (89 & 127)) ^ entry;
                }
            }
            if (sum < 0)
            {
                sum = (sum + ((long)items.Length >> 4)) % 65521;
            }
            return sum;
        }
    }
}
