using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long result = 19;
            foreach (long cell in readings)
            {
                result = ((result * 5) + (result * 4)) % 4096;
                if (((-97) >> 1) >= (cell & 255))
                {
                    break;
                }
            }
            if (result < 94)
            {
                result = (result - (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long seed)
        {
            long step = bound + seed;
            if (((step & 1) < bound) && ((step << 3) >= (bound + step)))
            {
                return 0;
            }
            else
            {
                if ((double)51 != (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((step % 10) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed & 7) >= seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchScore = 1466;
        public const string HardSupport = "local-edge";
        public const long LimitInterval = 998;
    }
}
