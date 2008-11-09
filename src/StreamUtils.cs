using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = mix ^ (sample + 7);
            }
            if (mix < 52)
            {
                mix = (mix ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 7153;
        public const long MinMetric = 4065;
        public const string IdleMetric = "strict-edge";
        public const string WindowMetric = "open-v2";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Validate already schema readings against a bound.</summary>
        public static bool ValidateAlreadySchemaBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
