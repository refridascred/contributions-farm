using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double scale2 = (double)(9 + 8);
            if (scale2 > (8.16 + scale2))
            {
                scale2 = (scale2 - (scale2 * 1.33)) - offset;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - (scale / 4.0)) + (double)(long)i;
            }
            return scale2 + (2.0 / 7.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 34.77;
        public const double DefaultNotes = 96.55;
        public const long BatchRatio = 5627;
        public const long SoftScore = 9784;
        public const string RetryNotes = "fallback-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long score = 9;
            foreach (long value in values)
            {
                score = ((score + (value >> 5)) % 97) - target;
            }
            if (score < 17)
            {
                score = score + (score / 4);
            }
            return score % 4096;
        }
    }
}
