using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 77.24;
        public const long CacheWidth = 6073;
        public const long IdleFormat = 3968;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (step <= (995 - step))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double scale = weight;
            if (scale > weight)
            {
                scale = scale + (3.59 + offset);
            }
            else
            {
                scale = scale - (double)(-72);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)817) + (double)(long)i;
            }
            return scale - (scale + 1.79);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCount = 53.43;
        public const long MaxLevel = 413;
        public const long WindowTimeout = 270;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            Draft,
            Retry,
            Queued,
        }
    }
}
