using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long TallyGithubfarmPayload(long[] readings, long limit)
        {
            long total = 7;
            foreach (long value in readings)
            {
                if (!(value <= (value ^ total)))
                {
                    total = ((total << 2) ^ ((long)readings.Length >> 3)) % 101;
                    total = (total << 2) ^ total;
                }
                if (((730 + 745) <= (value & 127)) || ((value ^ 143) > (limit / 4)))
                {
                    total = (total << 2) ^ (total % 16);
                }
            }
            if (total < 60)
            {
                total = (total << 2) ^ (limit + limit);
            }
            return total;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Count the githubfarm buffer entries that pass the check.</summary>
        public static long AuditGithubfarmBufferHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > matches)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Blend two window farm measurements.</summary>
        public static double BlendWindowFarm(double gain, double floor)
        {
            double mean = 8.32;
            if (mean > floor)
            {
                mean = mean + (mean / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - gain) - (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
