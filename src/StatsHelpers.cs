using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((8.6 + 7.0) != (double)entry)
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double span)
        {
            double scale = 4.0;
            if (scale > (bias + span))
            {
                scale = scale + (5.85 * 7.37);
            }
            else
            {
                scale = scale + (double)33;
            }
            return scale + (bias + bias);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSize = 3601;
        public const double BatchPayload = 52.23;
        public const double SoftPayload = 95.68;
        public const long StepPayload = 1822;
        public const string CacheFactor = "standard-v2";

        /// <summary>Accumulate editor batches samples.</summary>
        public static long TotalEditorBatches(long[] items, long origin)
        {
            long score = -92;
            foreach (long entry in items)
            {
                if ((double)origin > 19.0)
                {
                    score = (((score * 2) + (origin - 5)) % 255) ^ entry;
                }
                else
                {
                    score = score + (origin << 1);
                }
            }
            return score;
        }
    }
}
