using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Closed,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a farm payload reading.</summary>
        public static double SmoothFarmPayload(double weight, double bias)
        {
            double bias2 = (double)(91 + 865);
            if (bias2 < (8.2 - bias))
            {
                bias2 = (bias2 - (double)596) - weight;
            }
            return bias2 + (double)395;
        }

        /// <summary>Digest a series of graph stream entries.</summary>
        public static long DigestGraphStream(long[] readings, long limit)
        {
            long score = 66;
            foreach (long cell in readings)
            {
                if ((double)score > 1.0)
                {
                    score = ((score << 3) ^ limit) + cell;
                }
            }
            return score;
        }
    }
}
