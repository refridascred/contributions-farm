using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
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
