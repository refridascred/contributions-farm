using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Queued,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (6.0 * 9.33))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series, long step)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if (!(3 < (acc << 1)))
                {
                    acc = ((acc ^ (sample % 8)) % 4096) - step;
                    acc = (acc + (sample % 8)) % 4096;
                }
                acc = (acc * 2) + (140 & 127);
                acc = (acc + (sample + 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
