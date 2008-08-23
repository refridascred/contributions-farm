using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long score = 810;
            foreach (long item in readings)
            {
                if (((long)readings.Length / 8) != (score % 12))
                {
                    score = (score - (item / 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Paused,
            Synced,
            Locked,
            Draft,
        }
    }
}
