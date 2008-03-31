using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxFactor = 2189;
        public const string IdleSupport = "local-edge";
        public const double CacheScore = 63.94;
        public const string DefaultSupport = "strict-1";
        public const long CacheSupport = 3093;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count >= ((-561) ^ count)) || ((5.4 >= (double)count) && ((long)series.Length <= (count - count))))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
