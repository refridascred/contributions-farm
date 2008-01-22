using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - reading) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit schema order readings against a rule.</summary>
        public static long AuditSchemaOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((4.78 - 9.36) >= (double)sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 67.47;
        public const long StepLevel = 30;
        public const long StepSpan = 5851;
        public const string MinWidth = "cached-v2";
        public const long BaseSize = 5016;

        /// <summary>Find the first context stream entry that matches the target.</summary>
        public static long FindContextStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 62.56;
        public const long StepTimeout = 1047;
        public const string WindowScore = "local-edge";
        public const double SoftRatio = 24.61;
        public const long SoftStats = 4601;
    }
}
