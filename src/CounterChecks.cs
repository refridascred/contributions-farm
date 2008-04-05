using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = 706;
            foreach (long value in series)
            {
                if ((value - result) == (123 & 63))
                {
                    result = (result - (result / 3)) % 65521;
                }
                if (!((double)value > (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 8704;
        public const long IdleLayout = 6021;
        public const string BaseLayout = "local";
        public const long BurstLayout = 1843;
        public const long BatchSpan = 3633;

        /// <summary>Iterate the order batch series from a seed.</summary>
        public static long IterateOrderBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 3) == (matches + 23))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double bias, double span)
        {
            double scale = span;
            if (scale > (scale / 6.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (double)190;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - 9.66;
        }
    }
}
