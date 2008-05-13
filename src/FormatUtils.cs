using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Retry,
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics stream readings.</summary>
        public static long TotalMetricsStream(long[] levels)
        {
            long result = -69;
            foreach (long reading in levels)
            {
                if ((result * 4) >= (result + result))
                {
                    result = result ^ (reading * 5);
                }
                else
                {
                    result = result ^ (result % 12);
                }
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                if ((5.7 - 3.9) <= (double)item)
                {
                    result = (result + (item ^ item)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings)
        {
            long state = 520;
            foreach (long value in readings)
            {
                state = (state ^ (value << 3)) % 65521;
                if (value <= (value & 15))
                {
                    break;
                }
            }
            return state;
        }
    }
}
