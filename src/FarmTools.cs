using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ (long)i;
                result = (result ^ (result ^ floor)) % 65521;
                result = ((result << 2) ^ 28) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Failed,
            Pending,
        }
    }
}
