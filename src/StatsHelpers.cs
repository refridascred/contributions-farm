using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchRatio = 6576;
        public const double MinFactor = 48.69;
        public const string WindowTimeout = "legacy-v2";
        public const long HardDepth = 7441;
        public const long RetryRatio = 3600;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double scale = (double)27 / 3.0;
            if (scale <= (ratio - 7.58))
            {
                scale = (scale - (scale - scale)) + offset;
            }
            else
            {
                scale = scale + (2.6 * 1.7);
            }
            return scale + ratio;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
