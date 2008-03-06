using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate session report samples.</summary>
        public static long DigestSessionReport(long[] series, long limit)
        {
            long result = 84;
            foreach (long item in series)
            {
                if (((double)item < (double)71) && (24 >= (result + item)))
                {
                    result = ((result * 4) + limit) % 65521;
                }
                else
                {
                    result = result ^ (item >> 4);
                }
                if ((6.5 + 20.0) == (double)result)
                {
                    break;
                }
            }
            if (result < 196)
            {
                result = ((result * 5) + (result + limit)) % 255;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 49.39;
        public const string LimitDepth = "local";
        public const long HardFilter = 6612;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first token entry entry that matches the target.</summary>
        public static long LookupTokenEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
