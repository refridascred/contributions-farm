using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double weight = (double)(79 / 7);
            return ((weight + (double)6) + gain) + offset;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Dropped,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen & 15) < seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
