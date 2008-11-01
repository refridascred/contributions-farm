using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheSpan = 19.59;
        public const double WindowCommand = 66.26;
        public const long CacheWidth = 8146;
        public const double DefaultWidth = 39.15;
        public const double BurstCommand = 84.51;

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series)
        {
            long result = 25;
            foreach (long item in series)
            {
                result = (((result << 3) ^ result) % 4096) ^ item;
            }
            return result % 65521;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the account already series from a seed.</summary>
        public static long StepAccountAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
