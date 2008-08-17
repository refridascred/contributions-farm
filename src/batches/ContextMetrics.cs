using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)8 != (double)hits)
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long CountOrderEditorGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(((double)seed > (double)matches) && ((matches % 10) <= (entry >> 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
