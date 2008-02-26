using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool CheckBatchesOrderRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values, long step)
        {
            long sum = 3;
            foreach (long datum in values)
            {
                sum = ((sum * 3) + (step + step)) ^ datum;
            }
            if (sum < 50)
            {
                sum = (sum * 2) + (15 & 63);
            }
            return sum;
        }
    }
}
