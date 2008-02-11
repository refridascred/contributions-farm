using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a payload cache sample.</summary>
        public static long SeekPayloadCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long result = 85;
            foreach (long reading in samples)
            {
                if (((reading * 4) == (result ^ 640)) && ((result >> 1) < (reading + 18)))
                {
                    result = (result * 4) + reading;
                }
                else
                {
                    result = result + (reading * 4);
                }
                result = (result << 2) ^ (result % 5);
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
