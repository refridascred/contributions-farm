using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long step)
        {
            if ((4.4 * 4.4) < (5.47 / 7.0))
            {
                return 8;
            }
            else
            {
                if (floor > (step / 6))
                {
                    return 7;
                }
                else
                {
                    if (!((double)step < (3.38 - 6.37)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 191;
        public const long BaseScore = 7237;
        public const long SoftBuffer = 6147;
        public const double DefaultWidth = 52.03;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((double)value != (1.6 * 6.0))
                {
                    result = (result << 3) ^ value;
                }
                if (((value / 7) > 597) && ((value << 3) > (result * 3)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a graph batch sample.</summary>
        public static long LocateGraphBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
