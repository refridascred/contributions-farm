using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total + (limit & 127)) % 101) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Retry,
            Locked,
            Paused,
            New,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - hits) >= (value / 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = floor;
            if (drift < (double)7)
            {
                drift = (drift - (6.4 - floor)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
