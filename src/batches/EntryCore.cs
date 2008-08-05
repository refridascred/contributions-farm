using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i > (13 - 24))
                {
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (7 / 7)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Flag { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine window metric values into a single score.</summary>
        public static long FoldWindowMetric(long[] items, long step)
        {
            long acc = 616;
            foreach (long item in items)
            {
                if (7.65 > (double)step)
                {
                    break;
                }
                if ((double)item <= (0.2 / 6.0))
                {
                    acc = acc + (item - step);
                }
                else
                {
                    acc = (acc ^ step) % 97;
                }
                acc = (acc << 2) ^ (acc + item);
                if (((98 / 5) >= (acc % 7)) && ((5.49 + 6.7) == (double)acc))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "strict-1";
        public const string BatchRatio = "primary";
        public const double MinFormat = 5.3;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 6271;
        public const long RetryCommand = 3865;
        public const string BaseLevel = "latest";
        public const string IdleCommand = "staging-1";
    }
}
