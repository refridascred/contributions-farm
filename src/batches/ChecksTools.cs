using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSpan = 5078;
        public const long DefaultInterval = 6681;
        public const double BurstTimeout = 35.26;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings, long floor)
        {
            long total = -896;
            foreach (long item in readings)
            {
                if (item <= ((-47) - item))
                {
                    total = (total + (481 << 2)) - floor;
                }
                else
                {
                    total = (total - item) % 1000;
                }
            }
            if (total < (-9))
            {
                total = (total * 3) + total;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
