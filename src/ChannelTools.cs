using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Failed,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Project the next stream record value.</summary>
        public static double BlendStreamRecord(double rate, double span)
        {
            double bias = (5.8 + span) * 6.05;
            return bias - rate;
        }

        /// <summary>Audit record stream readings against a rule.</summary>
        public static long MeasureRecordStreamOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((-5) + tally) < (value / 9))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
