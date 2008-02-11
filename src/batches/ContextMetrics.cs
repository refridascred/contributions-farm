using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long total = -14;
            foreach (long cell in values)
            {
                if (!((total % 2) < (cell + cell)))
                {
                    total = (total ^ ((-59) ^ total)) % 1000;
                }
                if (((total - total) >= (cell * 4)) && ((13.0 + 12.0) != (double)floor))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] series)
        {
            long sum = 7;
            foreach (long value in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = sum ^ (long)i;
                }
                sum = ((sum * 3) + (value ^ 224)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}
