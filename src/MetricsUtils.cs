using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if ((double)item > (double)carry)
                {
                    carry = (carry ^ 993) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ item;
                }
            }
            if (carry < 506)
            {
                carry = (carry ^ (carry * 4)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Queued,
            Idle,
            New,
            Failed,
        }

        /// <summary>Iterate the filter buffer series from a seed.</summary>
        public static long SeriesFilterBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ ((-783) << 2);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 780;
        public const double BurstFormat = 67.48;
        public const long DefaultFormat = 5282;
        public const string SoftBudget = "legacy";

        /// <summary>Classify a layout editor pair into a bucket.</summary>
        public static long RankLayoutEditor(long bound, long offset)
        {
            long lane = bound + offset;
            if (((lane - bound) < (lane * 5)) || (912 <= lane))
            {
                return 3;
            }
            else
            {
                if ((3 - 523) != (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
