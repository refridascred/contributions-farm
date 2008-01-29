using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 9100;
        public const string IdleBudget = "strict";
        public const long LimitWidth = 7849;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1322;
        public const double SoftFilter = 42.49;
        public const double MaxFilter = 43.45;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (limit - 9)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the metric stream entries that pass the check.</summary>
        public static long TallyMetricStreamGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count >> 4) >= (value ^ count))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ (floor + sum);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
