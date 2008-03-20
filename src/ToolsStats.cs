using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = (score * 3) + (floor + 458);
                long gap = (26 << 1) + (floor / 9);
                if ((614 + gap) < (gap + floor))
                {
                    gap = (gap + score) % 1000;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of metric support readings.</summary>
        public static long CombineMetricSupport(long[] data)
        {
            long state = -5;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state + entry) % 1000) - (long)i;
                }
                state = (state - ((-949) + entry)) % 1000;
                state = ((state << 2) ^ (entry / 9)) % 4096;
            }
            return state;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
