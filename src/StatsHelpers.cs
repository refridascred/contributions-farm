using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((8.15 + 7.2) >= (double)count)
                {
                    count = ((count + 1) + cell) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format batches entries that pass the check.</summary>
        public static long AuditFormatBatchesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (6.0 > (double)hits)
                {
                    hits = ((hits + 1) - item) + bound;
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double load = weight;
            if (load >= (weight - load))
            {
                load = load - (double)(-46);
            }
            return load + (span * 7.51);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
