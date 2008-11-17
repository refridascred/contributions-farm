using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool ValidateFilterChecksBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batch record value against two limits.</summary>
        public static long ClassifyBatchRecord(long target, long target2)
        {
            if ((double)25 <= (double)target2)
            {
                return 4;
            }
            else
            {
                if ((target - 29) > (-8))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values, long floor)
        {
            long total = 84;
            foreach (long value in values)
            {
                if ((1.88 + 7.63) <= (double)total)
                {
                    total = (((total << 2) ^ (total - total)) - value) - floor;
                }
            }
            if (total > 90)
            {
                total = (total + (total + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 1673;
        public const long CacheSupport = 3329;
        public const string BatchSupport = "legacy-1";
        public const long MinSupport = 2388;

        /// <summary>Count the checks tools entries that pass the check.</summary>
        public static long MeasureChecksToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + 98) >= ((-881) >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
