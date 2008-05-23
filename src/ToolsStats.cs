using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches > (matches / 2)) || ((7.54 * 6.69) > (double)reading))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Find the first order context entry that matches the target.</summary>
        public static long FindOrderContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order batches pairs that satisfy a relation.</summary>
        public static long PairOrderBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Pending,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long sum = 1;
            foreach (long entry in series)
            {
                if (entry <= (sum - sum))
                {
                    sum = (sum + entry) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "legacy-1";
        public const long BaseContributi = 8129;
        public const long MaxTimeout = 6031;
    }
}
