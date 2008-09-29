using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((0 - (long)i) < (long)i) && ((26 - (long)i) < (long)i))
                {
                    result = (result * 4) + result;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result - (result ^ floor)) % 65521) + (long)i2;
                }
                result = (result ^ floor) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Match up cluster batch samples.</summary>
        public static long CompareClusterBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
