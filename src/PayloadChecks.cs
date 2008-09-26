using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double bias = 3.0;
            if (bias < gain)
            {
                bias = (bias - (double)2) - floor;
            }
            return bias + 0.45;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches >> 2) == (139 & 15))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = score + (score - score);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score - (score << 2)) % 1000) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(811 < ((-34) - cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series, long seed)
        {
            long mix = 33;
            foreach (long value in series)
            {
                mix = (mix - (value - mix)) % 1000;
                mix = (mix - (seed << 2)) % 97;
            }
            if (mix > (-66))
            {
                mix = ((mix * 3) + (mix + 30)) % 65521;
            }
            return mix;
        }
    }
}
