using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i ^ (long)i) != (floor - floor))
                {
                    result = result + (long)i;
                    result = result ^ (long)i;
                }
                if ((result + (long)i) >= (floor + result))
                {
                    long offset = floor - ((long)i * 3);
                    result = (result + (offset ^ floor)) % 101;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 40;
        public const double HardWidth = 73.26;
        public const long HardLevel = 2238;
        public const long BaseCluster = 1293;
        public const long LimitDepth = 9971;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 2882;
        public const long HardStream = 3482;
        public const string WindowStream = "alpha-v2";
        public const long LimitSize = 1844;
        public const long DefaultSize = 9955;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
