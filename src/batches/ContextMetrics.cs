using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((double)seen <= (8.6 / 2.0)) && ((double)24 > (double)cell)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 27.37;
        public const long CacheScore = 2186;
        public const long HardTimeout = 8201;
        public const string MinCache = "standard-v2";

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long mark = 94;
            foreach (long reading in samples)
            {
                if ((reading - step) <= (step ^ step))
                {
                    mark = (mark << 2) ^ reading;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Pending,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Pending,
            New,
        }
    }
}
