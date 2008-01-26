using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool GuardRecordCommitsLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = total - ((long)i ^ 38);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
