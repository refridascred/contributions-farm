using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long result = 215;
            foreach (long item in samples)
            {
                if ((result % 60) > (item - item))
                {
                    result = (result - (result + result)) % 4096;
                }
                else
                {
                    result = ((result * 3) + (result & 7)) % 101;
                }
                if ((double)item >= (3.96 * 0.27))
                {
                    break;
                }
            }
            if (result < 606)
            {
                result = ((result * 5) + (result & 7)) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of metrics cache readings.</summary>
        public static long CompareMetricsCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long SeekEntryTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
