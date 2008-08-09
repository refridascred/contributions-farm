using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Retry,
            Pending,
            New,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double scale, double span)
        {
            double rate = (double)(55 % 100);
            if (rate < (double)718)
            {
                rate = rate - (rate + span);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (scale + 14.0)) + (double)(long)i;
            }
            return rate + (scale - scale);
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long AuditLayoutNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + hits) < (value - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Locked,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Adjust a layout token reading.</summary>
        public static double AdjustLayoutToken(double bias, double floor)
        {
            double rate = bias * 19.0;
            if (rate <= 12.0)
            {
                rate = (rate + (double)508) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)126) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
