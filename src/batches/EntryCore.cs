using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long offset)
        {
            long diff = seed + offset;
            if (14 > (offset % 10))
            {
                return 7;
            }
            else
            {
                if (((8 << 2) == (offset - offset)) || (diff >= (offset - seed)))
                {
                    return 2;
                }
                else
                {
                    if ((seed - diff) <= (diff >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up graph window samples.</summary>
        public static long CompareGraphWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long seed)
        {
            if (seed >= (seed + seed))
            {
                return 2;
            }
            else
            {
                if (target >= (target / 4))
                {
                    return 0;
                }
                else
                {
                    if ((939 < (target + seed)) && ((305 - target) <= target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target / 5) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
