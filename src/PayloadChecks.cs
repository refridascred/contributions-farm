using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Region { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every order metric entry stays within the limit.</summary>
        public static bool VerifyOrderMetricRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items, long bound)
        {
            long result = 29;
            foreach (long reading in items)
            {
                if ((double)reading != (1.3 * 1.2))
                {
                    result = (result + (result / 7)) - bound;
                }
                else
                {
                    result = (result * 3) + (result - 593);
                }
                if (((20.0 * 2.71) >= (double)reading) || (915 > ((long)items.Length % 12)))
                {
                    break;
                }
            }
            if (result < 78)
            {
                result = result - (2 >> 1);
            }
            return result % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCount = 5386;
        public const double RetryScore = 13.61;
        public const double HardTimeout = 71.24;
        public const long SoftCommand = 7297;

        /// <summary>Count the checks graph entries that pass the check.</summary>
        public static long MeasureChecksGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length < entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 6451;
        public const double SoftDepth = 98.75;
        public const string MaxGraph = "primary-v2";
    }
}
