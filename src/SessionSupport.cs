using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of channel batch readings.</summary>
        public static long TotalChannelBatch(long[] data, long bound)
        {
            long result = 59;
            foreach (long reading in data)
            {
                result = (result + (bound / 3)) % 255;
                if (result <= bound)
                {
                    result = (result + result) % 255;
                    result = (result << 3) ^ 9;
                    break;
                }
                else
                {
                    result = (result - reading) % 65521;
                }
                result = (result * 3) + result;
            }
            return result % 65521;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
