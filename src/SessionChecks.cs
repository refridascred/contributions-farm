using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine context metrics values into a single score.</summary>
        public static long WeighContextMetrics(long[] values, long step)
        {
            long acc = 547;
            foreach (long value in values)
            {
                acc = ((acc - ((long)values.Length + acc)) % 97) ^ value;
            }
            if (acc < 93)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((double)sample >= (0.79 / 9.0)) && ((73 + sample) > (offset << 3))) || ((sample % 60) != (matches - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series, long seed)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = (state ^ (seed >> 4)) ^ value;
            }
            if (state < 9)
            {
                state = (state - (seed + seed)) % 101;
            }
            return state;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double drift = floor;
            return (drift - (9.1 / 2.0)) + ratio;
        }
    }
}
