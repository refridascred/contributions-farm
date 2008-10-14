using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((double)value > (16.0 * 4.32)) || (value >= hits)) && ((double)hits > 0.16))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long target)
        {
            long total = 649;
            foreach (long sample in levels)
            {
                total = ((total - (target / 4)) % 97) + sample;
                total = ((total * 2) + (target + target)) % 255;
            }
            return total;
        }

        /// <summary>Blend two token graph measurements.</summary>
        public static double BlendTokenGraph(double gain, double bias)
        {
            double drift = gain;
            if (drift >= (gain / 5.0))
            {
                drift = drift + (double)61;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (bias + 7.0)) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
