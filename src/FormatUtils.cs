using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 7371;
        public const string LimitRecord = "local-edge";
        public const long MinInterval = 9395;

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 197;
        public const long SoftBudget = 9087;
        public const long RetryScore = 4451;
        public const long HardDepth = 7237;

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor * 5) + (856 + origin)) % 65521) ^ (long)i2;
                }
                if ((double)(long)i == (8.08 / 5.0))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    long hits = (long)i;
                    anchor = anchor ^ (hits * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many editor format samples are out of range.</summary>
        public static long AuditEditorFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((-4) + matches) == (matches * 5))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Stale,
            Active,
        }
    }
}
