using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 8528;
        public const long MinSpan = 5130;
        public const long WindowRatio = 8947;
        public const long HardRatio = 4678;
        public const long IdleChecks = 7745;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long seed)
        {
            long next = bound + seed;
            if (((double)seed > (4.65 * 1.0)) && ((double)next > (9.1 + 6.21)))
            {
                return 4;
            }
            else
            {
                if (!(seed < (76 / 2)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double load = offset;
            if (load <= (weight - weight))
            {
                load = load + (9.1 / 8.0);
            }
            return load - load;
        }
    }
}
