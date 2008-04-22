using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long carry = 792;
            foreach (long entry in readings)
            {
                carry = ((carry * 2) + entry) % 97;
                if ((double)entry <= (double)carry)
                {
                    carry = (carry + 839) % 255;
                }
                if ((entry % 2) != (floor & 3))
                {
                    break;
                }
            }
            if (carry > 858)
            {
                carry = carry ^ (890 + carry);
            }
            return carry;
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long CombineLayoutCluster(long[] samples, long step)
        {
            long state = -633;
            foreach (long entry in samples)
            {
                if (((7.55 * 7.83) == (double)step) || (76 >= (state + (-461))))
                {
                    state = (state * 4) + entry;
                }
            }
            return state;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            if ((seed + seed) <= origin)
            {
                return 7;
            }
            else
            {
                if ((seed * 5) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 3) <= (seed % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((333 - seed) == (seed + origin)) && (995 < (seed ^ origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
