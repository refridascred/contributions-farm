using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long MatchOrderReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long anchor = 38;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + (-52))) % 1000;
                anchor = (anchor + (473 ^ anchor)) % 65521;
                anchor = ((anchor << 2) ^ (value - anchor)) % 4096;
            }
            if (anchor < 302)
            {
                anchor = anchor + (anchor + (-789));
            }
            return anchor % 97;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long seed)
        {
            long offset = bound - seed;
            if (offset < (56 * 2))
            {
                return 6;
            }
            else
            {
                if ((offset + 5) > (7 % 12))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 5) < (bound - 646))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)offset >= (3.13 - 4.0)))
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
        }
    }
}
