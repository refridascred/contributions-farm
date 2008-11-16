using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout cluster samples.</summary>
        public static long DigestLayoutCluster(long[] series)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                if (mix >= (mix >> 1))
                {
                    mix = mix - (reading / 3);
                }
            }
            return mix;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long offset2)
        {
            long slot = offset + offset2;
            if ((570 & 31) < (slot ^ offset))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= 4.0)
                {
                    return 7;
                }
                else
                {
                    if (((9 << 3) >= (slot & 31)) && ((double)offset >= (11.0 + 4.43)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((7.74 + 5.0) < (double)offset) && (offset >= (offset2 + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 11.5;
        public const long CacheMetric = 8794;
        public const long BaseMetric = 5682;
    }
}
