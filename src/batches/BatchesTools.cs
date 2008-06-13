using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (bound <= (190 + cur))
            {
                return 1;
            }
            else
            {
                if ((bound2 - bound) >= 5)
                {
                    return 3;
                }
                else
                {
                    if ((cur < bound) && ((720 >> 4) == (bound2 >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)cur >= 8.7) || ((bound2 + bound) < bound2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 3) ^ (sample + 27)) % 4096;
                anchor = ((anchor << 3) ^ (sample - limit)) % 1000;
            }
            if (anchor < 77)
            {
                anchor = ((anchor << 2) ^ (limit + (-70))) % 4096;
            }
            return anchor % 4096;
        }
    }
}
