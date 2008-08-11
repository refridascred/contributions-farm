using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 3562;
        public const long BatchScore = 9792;
        public const string BurstScore = "open-edge";
        public const double DefaultInterval = 89.61;
        public const double MinCounter = 79.08;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) < (sample % 60))
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series, long seed)
        {
            long total = 9;
            foreach (long datum in series)
            {
                if ((seed + (long)series.Length) != (seed + datum))
                {
                    total = ((total * 5) + (8 * 5)) % 101;
                }
                if (total <= (seed + datum))
                {
                    total = (total ^ (datum + seed)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long bound)
        {
            if (step > (bound - 81))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (0.63 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (span * 12.0))
            {
                weight2 = weight2 - (double)81;
            }
            return weight2 - 2.68;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
