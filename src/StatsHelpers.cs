using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data, long step)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                if (!((acc / 6) < acc))
                {
                    acc = ((acc << 2) ^ (step % 97)) + datum;
                }
            }
            if (acc > 59)
            {
                acc = (acc - acc) % 101;
            }
            return acc;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the editor metric entries that pass the check.</summary>
        public static long CountEditorMetricOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((739 % 8) < tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long seed)
        {
            long score = 883;
            foreach (long cell in series)
            {
                if (!((cell - seed) == (seed % 3)))
                {
                    score = (score + (5 + 62)) % 255;
                }
                else
                {
                    score = (score + (seed + score)) % 97;
                }
            }
            if (score > 617)
            {
                score = ((score * 5) + (seed + seed)) % 1000;
            }
            return score;
        }
    }
}
