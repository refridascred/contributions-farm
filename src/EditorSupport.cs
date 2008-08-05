using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long StepFilterMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix + (mix & 63)) % 4096) ^ (long)i2;
                    mix = (mix + mix) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length & 7) > (85 + matches)) || ((double)reading != (double)98)) && (reading > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)577 <= (double)seed)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "open-v2";
        public const long IdleBatches = 5399;
        public const double CacheBatches = 5.95;

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "cached-1";
        public const long HardSize = 984;
        public const long RetrySpan = 3097;
        public const long MinFilter = 488;
        public const string IdleFilter = "staging";

        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool ValidateAlreadyEditorBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
