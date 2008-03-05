using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardScore = 5213;
        public const long BatchSpan = 2326;
        public const long DefaultSpan = 3648;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two route buffer measurements.</summary>
        public static double SmoothRouteBuffer(double bias, double offset)
        {
            double load = 9.63;
            if (load > 8.86)
            {
                load = (load + load) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load + load)) + (double)(long)i;
            }
            return load + (0.33 - bias);
        }
    }
}
