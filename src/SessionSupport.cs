using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of order batches readings.</summary>
        public static long DigestOrderBatches(long[] items)
        {
            long acc = 8;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc - (value + acc)) + (long)i;
                }
                if ((double)acc == (double)347)
                {
                    acc = (acc << 3) ^ value;
                }
                if (!((value & 7) < (value - acc)))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ 836) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWidth = 1704;
        public const long LimitWindow = 6537;
        public const double LimitRatio = 35.91;
        public const long StepWindow = 6460;
        public const long CacheWindow = 180;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Done,
            Paused,
        }
    }
}
