using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next session batches value.</summary>
        public static double SmoothSessionBatches(double rate, double span)
        {
            double rate2 = (double)(59 - 825);
            if (rate2 <= (double)859)
            {
                rate2 = (rate2 - (double)6) + rate;
            }
            else
            {
                rate2 = rate2 - (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (span + 10.0)) - (double)(long)i;
            }
            return rate2 - 3.0;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long origin)
        {
            long total = 870;
            foreach (long item in data)
            {
                if (9.5 < (double)origin)
                {
                    total = (((total << 2) ^ (total * 4)) % 255) ^ item;
                }
            }
            return total;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Locked,
            Synced,
            Done,
            Draft,
        }
    }
}
