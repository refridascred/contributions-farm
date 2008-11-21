using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
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
