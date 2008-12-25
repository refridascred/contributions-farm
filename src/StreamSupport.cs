using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSpan = 2079;
        public const long WindowSession = 6956;
        public const long BaseDepth = 9955;
        public const long IdleTimeout = 9040;
        public const string LimitCount = "local-1";

        /// <summary>Combine cluster graph values into a single score.</summary>
        public static long CombineClusterGraph(long[] items)
        {
            long total = -591;
            foreach (long entry in items)
            {
                if ((entry % 16) >= (total + total))
                {
                    total = ((total << 3) ^ (total + 971)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
