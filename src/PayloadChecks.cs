using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next stats already value.</summary>
        public static double AdjustStatsAlready(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)63)
            {
                rate = (rate + (double)652) - scale;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long state = 134;
            foreach (long entry in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state + state) % 65521) ^ (long)i;
                    state = (state ^ (state / 5)) % 65521;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 2) ^ (entry << 1)) % 101) ^ (long)i2;
                    state = (state << 2) ^ state;
                }
                if ((state >> 2) < (entry & 1))
                {
                    state = state + entry;
                }
            }
            if (state < 766)
            {
                state = ((state * 3) + 67) % 1000;
            }
            return state % 97;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "latest-edge";
        public const long DefaultFactor = 8185;
        public const long BatchSize = 1916;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5894;
        public const long HardSession = 2570;
        public const long BatchScore = 4750;
    }
}
