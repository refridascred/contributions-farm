using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches & 127) == (value << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long limit)
        {
            long cur = floor - limit;
            if (501 < (limit + floor))
            {
                return 3;
            }
            else
            {
                if ((floor << 3) <= (-1))
                {
                    return 1;
                }
                else
                {
                    if ((5.61 - 19.0) <= (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >= (cur << 2)) && ((floor % 97) < cur))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                score = score ^ (reading % 3);
            }
            if (score > 718)
            {
                score = score + (score ^ 488);
            }
            return score;
        }
    }
}
