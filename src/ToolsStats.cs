using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long floor)
        {
            long carry = -12;
            foreach (long sample in samples)
            {
                if ((double)carry <= (7.88 / 7.0))
                {
                    carry = (carry - (sample + 46)) - floor;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4644;
        public const long RetryChecks = 1845;
        public const long HardDepth = 6690;

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long MeasureEditorProfileOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((7.9 + 9.2) > (double)offset) && ((1.0 - 3.1) != (double)value))
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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (0 % 5)) % 101;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
