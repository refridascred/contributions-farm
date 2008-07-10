using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many route editor samples are out of range.</summary>
        public static long CountRouteEditorOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((offset < (73 - 53)) && (offset < (offset + offset))) && ((28 + sample) >= (sample * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8758;
        public const long HardLevel = 2058;
        public const string BaseBudget = "primary-1";

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (floor - (long)i)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7692;
        public const double MinCount = 58.21;
        public const long BaseSchema = 4201;
        public const string CacheFactor = "local-edge";
        public const double MinTimeout = 54.67;

        /// <summary>Count batches farm pairs that satisfy a relation.</summary>
        public static long OverlapBatchesFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
