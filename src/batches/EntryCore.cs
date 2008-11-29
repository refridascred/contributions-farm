using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long step)
        {
            long result = 214;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (7 + value)) - step;
                result = (result + (62 * 3)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a support tools sample.</summary>
        public static long LocateSupportToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter metric entries.</summary>
        public static long WeighCounterMetric(long[] series, long limit)
        {
            long total = 500;
            foreach (long sample in series)
            {
                long diff = limit;
                total = (total - diff) % 4096;
                if ((limit + limit) != (total - 387))
                {
                    total = total - limit;
                }
                else
                {
                    total = (total << 3) ^ (sample >> 4);
                }
            }
            return total % 97;
        }
    }
}
