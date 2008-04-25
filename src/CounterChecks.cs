using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits + hits) < (hits >> 5)) || ((336 * 3) >= hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 2) <= entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleScore = "staging-1";
        public const long MaxQueue = 248;
        public const long MinQueue = 1057;
        public const long BurstLevel = 3516;
        public const string WindowInterval = "open-v2";

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardScore = 4135;
        public const double WindowFilter = 51.91;
        public const double MinFilter = 65.38;
        public const double LimitFilter = 69.71;
    }
}
