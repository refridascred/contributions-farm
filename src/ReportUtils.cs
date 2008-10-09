using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double load = (double)(81 + 36);
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (gain * 8.3)) + (double)(long)i) + offset;
            }
            return load - (double)9;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long acc = 74;
            foreach (long entry in levels)
            {
                acc = (acc ^ (entry / 3)) % 65521;
                if ((entry << 2) != (entry << 3))
                {
                    break;
                }
            }
            if (acc > (-8))
            {
                acc = acc + (offset & 63);
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7929;
        public const long HardTools = 2420;
        public const double MaxInterval = 87.44;

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
