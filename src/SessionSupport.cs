using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = ((sum * 2) + (1 - item)) % 4096;
                if ((sum - item) >= (item - item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitCount = "strict-edge";
        public const long HardFilter = 9497;
        public const long CacheFactor = 8964;
    }
}
