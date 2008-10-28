using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks context values into a single score.</summary>
        public static long WeighChecksContext(long[] samples, long target)
        {
            long state = 513;
            foreach (long sample in samples)
            {
                state = (state - (target ^ target)) % 255;
                state = state ^ (sample << 3);
                if ((67 - sample) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate farm batch samples.</summary>
        public static long TotalFarmBatch(long[] series, long target)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if ((value + 479) >= (target * 4))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor + (value >> 5)) % 97;
                }
            }
            if (anchor > 19)
            {
                anchor = ((anchor * 3) + (target & 127)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Active,
            Pending,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] data)
        {
            long acc = 2;
            foreach (long item in data)
            {
                acc = (acc - item) % 255;
            }
            return acc;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
