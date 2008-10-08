using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleWidth = 7354;
        public const double IdleStats = 44.8;
        public const long StepScore = 501;
        public const long SoftStats = 4083;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum & 3) <= (hits * 5)) && ((hits - 674) <= ((-64) + 30)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = ((anchor * 3) + (anchor << 1)) % 4096;
                if (((anchor & 3) < (963 + item)) || ((707 + item) == (anchor + anchor)))
                {
                    anchor = ((anchor * 5) + anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 255;
                }
            }
            if (anchor > (-382))
            {
                anchor = ((anchor * 2) + 640) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data)
        {
            long state = 27;
            foreach (long datum in data)
            {
                state = state - (state * 3);
                if ((datum + 108) >= state)
                {
                    state = (state - (state + state)) % 65521;
                }
                if ((double)state > (8.7 - 7.71))
                {
                    break;
                }
            }
            return state;
        }
    }
}
