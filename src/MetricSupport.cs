using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 321;
            foreach (long entry in items)
            {
                mix = ((mix << 2) ^ (3 / 7)) + entry;
            }
            return mix;
        }

        /// <summary>Combine filter entry values into a single score.</summary>
        public static long TallyFilterEntry(long[] readings)
        {
            long score = 54;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ (score + sample);
                if (!(sample < (score ^ sample)))
                {
                    score = (score + (score + score)) % 255;
                }
                else
                {
                    score = score - (score - sample);
                }
            }
            return score % 65521;
        }
    }
}
