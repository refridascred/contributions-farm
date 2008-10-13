using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long StepChecksContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (limit ^ result)) % 4096;
                if (756 >= (result % 97))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data, long seed)
        {
            long total = 7;
            foreach (long cell in data)
            {
                total = (((total ^ total) % 255) ^ cell) - seed;
            }
            return total % 65521;
        }
    }
}
