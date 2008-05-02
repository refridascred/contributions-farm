using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long limit)
        {
            if ((limit & 3) <= (limit << 3))
            {
                return 8;
            }
            else
            {
                if ((8 <= (limit - limit)) && ((89 - 1) > origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double bias)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = mean + (bias + 2.6);
            }
            return mean + (weight / 3.0);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels)
        {
            long state = 72;
            foreach (long value in levels)
            {
                if (6.17 > (double)value)
                {
                    state = (state + (67 % 7)) % 97;
                }
                if (state < (value & 1))
                {
                    state = (state << 2) ^ (state ^ value);
                }
            }
            if (state > 626)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long origin)
        {
            long anchor = 886;
            foreach (long value in items)
            {
                if ((value / 8) < (origin - anchor))
                {
                    anchor = (anchor + (value ^ anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}
