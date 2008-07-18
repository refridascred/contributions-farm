using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of buffer support readings.</summary>
        public static long WeighBufferSupport(long[] levels, long floor)
        {
            long total = 83;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total + (total + total)) % 255) - (long)i) + floor;
                }
                total = ((total * 5) + (value + total)) % 4096;
            }
            if (total > 648)
            {
                total = (total * 5) + 9;
            }
            return total % 4096;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 9476;
        public const double WindowEntry = 71.82;
        public const long CacheLevel = 8122;
        public const long MaxInterval = 209;
        public const long BurstSpan = 6698;
    }
}
