using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((125 - item) <= (9 - 795))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long step)
        {
            long total = 253;
            foreach (long item in levels)
            {
                total = (total ^ step) + item;
            }
            return total % 4096;
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
