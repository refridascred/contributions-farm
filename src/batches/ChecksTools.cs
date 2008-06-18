using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if (63 <= (datum + datum))
                {
                    result = ((result << 3) ^ (388 / 2)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 5.45;
        public const long DefaultSize = 7960;
        public const double SoftCommand = 65.24;
        public const string HardCommand = "stable-edge";
        public const long BatchCommand = 9173;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
