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

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((11.0 / 6.0) < (double)origin)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
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
