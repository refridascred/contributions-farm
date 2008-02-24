using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double load = (floor / 3.0) / 4.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (floor / 9.0)) - (double)(long)i) - ratio;
            }
            return load + floor;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Idle,
            Draft,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long offset, long step)
        {
            long cur = offset + step;
            if (!((offset ^ cur) == (step & 15)))
            {
                return 2;
            }
            else
            {
                if ((7.0 <= (double)step) && ((double)step > (0.6 * 3.44)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (double)27 + 7.0;
            return ((load - (7.9 * 5.8)) + ratio) + offset;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values, long floor)
        {
            long total = 532;
            foreach (long entry in values)
            {
                total = (((total << 3) ^ floor) % 255) ^ entry;
            }
            return total;
        }
    }
}
