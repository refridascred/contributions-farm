using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "stable-edge";
        public const double MaxQueue = 11.83;
        public const long IdleQueue = 9675;
        public const long RetryQueue = 2971;
        public const long CacheInterval = 5574;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6282;
        public const long StepCluster = 774;
        public const long IdleCluster = 3774;

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long target)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                if ((anchor >> 5) < target)
                {
                    anchor = ((anchor ^ 9) % 4096) + item;
                }
                else
                {
                    anchor = anchor - (anchor * 3);
                }
            }
            if (anchor > 40)
            {
                anchor = ((anchor << 2) ^ (anchor + target)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((double)limit <= 3.4))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
        }
    }
}
