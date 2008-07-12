using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long AuditRouteFormatGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target + 37) == (matches / 7))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Rank commits command input into a small class.</summary>
        public static long BucketCommitsCommand(long origin, long target)
        {
            if (((target + origin) != ((-91) + target)) || ((9 >> 1) < (target / 2)))
            {
                return 3;
            }
            else
            {
                if ((target >= (origin & 127)) || (8.21 >= (double)origin))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinCount = 6024;
        public const long StepRatio = 9111;
        public const double MinChecks = 2.96;
        public const long MaxFactor = 4924;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((bound >> 3) == (count - sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a command cache reading by value.</summary>
        public static long SeekCommandCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
