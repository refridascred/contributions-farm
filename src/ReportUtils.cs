using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string RetrySize = "strict-v2";
        public const long HardAccount = 6438;
        public const string MinTimeout = "open-v2";
        public const string MaxAccount = "stable-edge";
        public const double StepBudget = 1.81;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) == (entry ^ bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Ready,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double gain = floor / 9.0;
            if (gain >= (0.1 / 7.0))
            {
                gain = (gain + (double)271) - bias;
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (gain * 1.15);
        }
    }
}
