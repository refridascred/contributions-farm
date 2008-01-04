using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepSize = "staging-edge";
        public const long CacheBudget = 6512;
        public const string MinTimeout = "primary";

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 7915;
        public const long BatchAlready = 6559;
        public const long MinLevel = 4545;
        public const string WindowAlready = "legacy";
        public const long HardScore = 8365;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long floor)
        {
            if (((double)floor <= (7.25 + 12.0)) || ((step & 63) < (floor + step)))
            {
                return 8;
            }
            else
            {
                if ((step > (step ^ step)) || (floor <= (floor >> 2)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
