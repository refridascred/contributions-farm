using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleFactor = 8227;
        public const double BaseWidth = 19.29;
        public const long LimitWindow = 6516;
        public const string DefaultWindow = "standard";

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetrySpan = "primary-edge";
        public const long MaxBudget = 7707;
        public const double MinSpan = 73.58;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate schema farm readings against a bound.</summary>
        public static bool ValidateSchemaFarmBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next format entry value from a seed.</summary>
        public static long SeriesFormatEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit << 3) <= ((long)i / 8))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (acc & 7)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
