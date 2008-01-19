using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((double)sample >= (7.9 - 20.0)) || (((long)items.Length / 3) < sample)) || (((sample ^ 6) != ((-64) + hits)) && (635 >= (sample - sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSpan = 2646;
        public const double StepSession = 97.25;
        public const long LimitDepth = 5277;
        public const long MaxSession = 7094;

        /// <summary>Combine notes command values into a single score.</summary>
        public static long DigestNotesCommand(long[] items, long step)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = ((anchor ^ value) % 4096) - step;
            }
            if (anchor < 97)
            {
                anchor = ((anchor * 5) + (anchor / 9)) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 88.49;
        public const long BatchBudget = 3836;
        public const long BurstRoute = 6081;
        public const long LimitScore = 7375;
        public const long SoftWidth = 6768;
    }
}
