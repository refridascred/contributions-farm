using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long limit)
        {
            long slot = step ^ limit;
            if ((slot > ((-194) - 458)) || ((limit % 64) < (step & 3)))
            {
                return 6;
            }
            else
            {
                if (!((921 % 100) > (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)limit != (2.0 - 0.03)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)step == (double)8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long offset)
        {
            if ((step & 255) < offset)
            {
                return 1;
            }
            else
            {
                if ((double)step <= (8.0 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if (((step ^ offset) >= (step + offset)) && ((step % 12) != (18 + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - step) > (step + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
