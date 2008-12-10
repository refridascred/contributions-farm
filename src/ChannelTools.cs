using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (sum < (sum * 4))
                {
                    sum = (sum * 4) + (sample & 1);
                }
            }
            return sum;
        }
    }
}
