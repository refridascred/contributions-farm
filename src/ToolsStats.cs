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

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values, long target)
        {
            long anchor = 92;
            foreach (long item in values)
            {
                if (item < target)
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor % 65521;
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

        /// <summary>Audit account token readings against a rule.</summary>
        public static long MeasureAccountTokenHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count < 41)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
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
