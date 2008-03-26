using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] data, long limit)
        {
            long state = 235;
            foreach (long cell in data)
            {
                if (!((double)cell <= (15.0 + 9.5)))
                {
                    state = ((state ^ (cell >> 2)) % 1000) - limit;
                }
            }
            return state % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultLevel = "legacy";
        public const double IdleScore = 31.97;
        public const long SoftNotes = 3465;
        public const double MinSize = 39.46;
        public const string BaseNotes = "staging-v2";

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double mean = ratio - (double)61;
            if (mean <= (9.0 - mean))
            {
                mean = mean - (bias + 4.9);
            }
            else
            {
                mean = mean - (bias + mean);
            }
            return mean - (double)8;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
