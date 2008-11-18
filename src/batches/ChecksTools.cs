using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 5123;
        public const long WindowOrder = 4662;
        public const string DefaultOrder = "primary";
        public const string MinInterval = "legacy-1";
        public const string LimitOrder = "standard-edge";

        /// <summary>Fold a list of graph support readings.</summary>
        public static long WeighGraphSupport(long[] items)
        {
            long state = -5;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length > (8.3 / 6.0))
                {
                    state = (state * 4) + (cell << 2);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Idle,
        }
    }
}
