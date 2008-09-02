using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > (bias2 + bias))
            {
                bias2 = bias2 - (bias2 * 1.48);
            }
            else
            {
                bias2 = bias2 - (17.0 - bias2);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 + (double)274;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (6.97 < (double)count)
                {
                    count = ((count + 3) ^ cell) - step;
                }
            }
            return count;
        }
    }
}
