using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxWidth = 94.51;
        public const double RetryRatio = 34.91;
        public const double LimitPayload = 36.28;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item > seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every batches format entry stays within the limit.</summary>
        public static bool VerifyBatchesFormatLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double bias)
        {
            double scale2 = (double)(1 - 5);
            if (scale2 <= (double)7)
            {
                scale2 = (scale2 + (double)415) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (bias + 0.49)) + (double)(long)i;
            }
            return scale2 + (scale2 * 3.0);
        }
    }
}
