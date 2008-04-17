using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of schema metric entries.</summary>
        public static long TallySchemaMetric(long[] samples)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                sum = (((sum << 2) ^ (sum % 12)) % 255) - item;
                sum = sum + (21 - sum);
            }
            if (sum > (-7))
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long anchor = 13;
            foreach (long value in readings)
            {
                anchor = (anchor << 3) ^ anchor;
                anchor = anchor ^ (anchor ^ value);
            }
            return anchor % 1000;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels, long offset)
        {
            long anchor = 78;
            foreach (long item in levels)
            {
                if ((anchor - item) >= (item + anchor))
                {
                    anchor = ((anchor ^ item) % 255) - offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 9129;
        public const long LimitSize = 9457;
        public const long StepInterval = 8736;
        public const string BatchTimeout = "strict-edge";
    }
}
