using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ ((-821) * 4)) % 4096;
                if ((value / 6) <= (mix - value))
                {
                    mix = (mix * 3) + (mix + mix);
                }
            }
            return mix;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm commits readings against a rule.</summary>
        public static long MeasureFarmCommitsOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally < cell)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Failed,
            Ready,
            Idle,
            Paused,
        }
    }
}
