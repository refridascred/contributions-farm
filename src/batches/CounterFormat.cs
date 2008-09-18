using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long step)
        {
            if ((step - offset) < (offset >> 4))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) < (offset / 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (7.04 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a context stats value against two limits.</summary>
        public static long RankContextStats(long seed, long floor)
        {
            if (9 < floor)
            {
                return 0;
            }
            else
            {
                if (seed >= 78)
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) >= 288)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor < (0.77 - 13.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
