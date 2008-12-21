using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ 394) <= matches)
                {
                    matches = ((matches + 2) ^ cell) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter route readings.</summary>
        public static long CompareFilterRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long MeasureQueueChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally != (4.72 / 9.0))
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
