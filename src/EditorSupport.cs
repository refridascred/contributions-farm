using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first route contributi entry that matches the target.</summary>
        public static long LookupRouteContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Locked,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long MeasureRouteFormatHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample >> 2))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state * 2) + ((long)i >> 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Iterate the filter buffer series from a seed.</summary>
        public static long RollFilterBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed % 100) < seed)
                {
                    acc = acc + seed;
                }
                else
                {
                    acc = acc - seed;
                }
                acc = (acc ^ (seed + 7)) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
