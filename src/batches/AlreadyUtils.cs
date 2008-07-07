using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool VerifyFarmBatchLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches < 981))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Stale,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long MeasureBufferWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > 5.74) || (((double)sample <= 5.0) || ((sample + sample) >= (hits >> 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
