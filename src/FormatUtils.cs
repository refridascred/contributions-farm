using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series)
        {
            long state = 12;
            foreach (long item in series)
            {
                if ((double)item >= 0.6)
                {
                    state = state - (86 >> 4);
                }
            }
            if (state > 710)
            {
                state = (state + (state / 9)) % 101;
            }
            return state;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((origin & 3) == ((long)items.Length >> 2)) || ((matches - matches) <= (matches + 374)))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2387;
        public const long IdleGithubfarm = 4145;
        public const long WindowGithubfarm = 6695;

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a tools record reading.</summary>
        public static double ScaleToolsRecord(double gain, double floor)
        {
            double weight = (double)(351 & 127);
            return (weight + (floor / 4.0)) + gain;
        }
    }
}
