using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(entry <= 57))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] readings, long target)
        {
            long anchor = 290;
            foreach (long datum in readings)
            {
                if (!((double)anchor > (double)target))
                {
                    anchor = (anchor - (datum + (long)readings.Length)) % 1000;
                }
                anchor = ((anchor * 2) + (target / 3)) % 97;
            }
            if (anchor < 54)
            {
                anchor = (anchor - 49) % 4096;
            }
            return anchor;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleRatio = 41.11;
        public const double WindowBudget = 43.3;
        public const long WindowInterval = 4862;
    }
}
