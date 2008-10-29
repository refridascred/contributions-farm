using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double offset)
        {
            double gain2 = (double)76 / 8.0;
            if (gain2 >= (offset * 5.32))
            {
                gain2 = gain2 - (double)0;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain2 - gain)) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item > seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 40.22;
        public const double BaseFactor = 95.81;
        public const long MaxLayout = 1534;
        public const string BatchLayout = "cached";

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if ((2.2 - 14.0) >= (double)cell)
                {
                    mix = ((mix * 2) + mix) % 4096;
                }
            }
            return mix;
        }
    }
}
