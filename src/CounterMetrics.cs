using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double ratio = 2.54;
            return (ratio + bias) + span;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((5.9 / 4.0) <= (double)seen) && (((seen + seen) != (3 % 12)) && ((seen * 4) <= (datum & 7))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
