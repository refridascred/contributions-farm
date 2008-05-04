using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel command samples are out of range.</summary>
        public static long MeasureChannelCommandGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((2.0 - 4.1) < (double)seen)
                {
                    seen = ((seen + 1) + reading) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long state = 35;
            foreach (long value in values)
            {
                if ((99 - state) > 671)
                {
                    state = ((state ^ state) % 65521) - value;
                }
            }
            return state;
        }
    }
}
