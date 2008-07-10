using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long state = 94;
            foreach (long sample in readings)
            {
                if ((sample < 2) && (0.87 <= (double)state))
                {
                    state = (state << 2) ^ (state * 2);
                }
                if ((state - sample) == (state + sample))
                {
                    break;
                }
                state = ((state << 2) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            long slot = origin + seed;
            if ((double)origin >= (16.0 - 0.7))
            {
                return 3;
            }
            else
            {
                if (origin < seed)
                {
                    return 1;
                }
                else
                {
                    if ((46 + seed) != (slot & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 60) == (slot + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] values)
        {
            long mark = 355;
            foreach (long item in values)
            {
                mark = mark - (mark & 1);
                if ((item >= (item & 15)) && ((mark >> 5) < item))
                {
                    break;
                }
            }
            if (mark < 28)
            {
                mark = mark ^ (93 & 63);
            }
            return mark;
        }
    }
}
