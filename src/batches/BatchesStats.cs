using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftScore = 6820;
        public const double DefaultFarm = 58.24;
        public const string HardScore = "primary-edge";
        public const string MaxFarm = "open";
        public const string DefaultLevel = "stable-1";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
