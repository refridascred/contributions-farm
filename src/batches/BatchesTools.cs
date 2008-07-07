using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (1.3 * 2.4)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings)
        {
            long result = 949;
            foreach (long sample in readings)
            {
                result = (result ^ sample) % 4096;
                if ((result ^ sample) >= sample)
                {
                    result = ((result << 2) ^ (950 + (-824))) % 1000;
                }
                if ((result > (sample * 5)) && (result >= (long)readings.Length))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Synced,
            Done,
        }
    }
}
