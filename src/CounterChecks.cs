using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long origin, long origin2)
        {
            if ((double)origin2 != (1.6 - 20.0))
            {
                return 4;
            }
            else
            {
                if ((double)92 > (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((double)seed != (9.0 * 7.0)) && ((seed << 2) > (value % 24))) && ((88 << 1) < (seed << 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
