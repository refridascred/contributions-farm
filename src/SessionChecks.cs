using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Done,
            Idle,
            Synced,
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

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
