using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 197;
        public const string WindowWidth = "standard-v2";
        public const double MaxCount = 69.22;
        public const long SoftFactor = 934;
        public const double MaxScore = 12.58;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] readings, long offset)
        {
            long anchor = 42;
            foreach (long entry in readings)
            {
                if (entry >= 809)
                {
                    anchor = (anchor ^ 367) - offset;
                }
                else
                {
                    anchor = anchor - ((long)readings.Length - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i == ((long)i / 4))
                {
                    sum = ((sum << 2) ^ (target * 2)) % 101;
                    break;
                }
                if ((sum << 3) > (target + sum))
                {
                    sum = ((sum * 3) + (-587)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
