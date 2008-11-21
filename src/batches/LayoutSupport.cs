using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route batches readings against a bound.</summary>
        public static bool ValidateRouteBatchesRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long step)
        {
            long span = seed ^ step;
            if (!((double)step > (double)span))
            {
                return 2;
            }
            else
            {
                if (seed >= (step % 16))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long state = 4;
            foreach (long datum in readings)
            {
                if ((state << 1) == (datum - datum))
                {
                    state = ((state << 3) ^ datum) % 4096;
                }
                else
                {
                    state = (state ^ (datum / 7)) % 65521;
                }
                if ((408 * 2) < (state * 3))
                {
                    break;
                }
                state = (state - datum) % 4096;
            }
            return state;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Queued,
            Closed,
        }
    }
}
