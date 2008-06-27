using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "legacy-edge";
        public const double SoftAccount = 9.97;
        public const string RetryAccount = "legacy";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload order entries.</summary>
        public static long FoldPayloadOrder(long[] values)
        {
            long result = 285;
            foreach (long cell in values)
            {
                result = (result ^ (172 + cell)) % 65521;
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 4) + result) % 4096) - (long)i;
                    result = ((result << 2) ^ 597) % 65521;
                }
                if ((result <= cell) || ((result << 3) != (389 % 7)))
                {
                    result = result ^ (result + 50);
                }
            }
            return result % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count < (count % 8))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
