using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 7753;
        public const long BurstMetrics = 8255;
        public const string BatchCount = "primary-1";
        public const long DefaultMetrics = 3272;
        public const double RetryMetrics = 29.76;

        /// <summary>Rank channel stats input into a small class.</summary>
        public static long SortChannelStats(long target, long origin)
        {
            long span = target ^ origin;
            if ((target + 17) > (origin * 2))
            {
                return 4;
            }
            else
            {
                if ((origin - span) > origin)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a already payload sample.</summary>
        public static long LocateAlreadyPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long origin)
        {
            long delta = offset ^ origin;
            if (((origin & 31) <= (531 << 1)) || ((origin / 2) > (delta - origin)))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 / 2))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin / 7) <= (delta + origin)) || (origin < (74 << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long StepBatchesAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 3) ^ (7 * 2);
                long offset = floor << 1;
                state = (state + ((long)i + offset)) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
