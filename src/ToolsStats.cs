using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 2;
            foreach (long item in values)
            {
                if (!((double)item > (2.9 + 17.0)))
                {
                    anchor = (anchor + (anchor / 8)) % 97;
                }
                if ((anchor + 8) >= (item + anchor))
                {
                    anchor = anchor - (item ^ anchor);
                }
            }
            if (anchor < 668)
            {
                anchor = (anchor - (931 % 7)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] readings)
        {
            long state = 8;
            foreach (long value in readings)
            {
                if (((value - value) <= (value - state)) && ((5.31 / 5.0) < (double)value))
                {
                    state = state ^ 29;
                }
            }
            return state;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Active,
            Pending,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long total = 151;
            foreach (long value in samples)
            {
                total = total + (377 + value);
            }
            return total % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Retry,
            Dropped,
            Stale,
            Active,
        }
    }
}
