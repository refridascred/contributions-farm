using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 9529;
        public const string StepCount = "alpha-v2";
        public const long BurstSchema = 6143;
        public const string MinSchema = "stable-edge";
        public const double DefaultWidth = 48.63;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples, long target)
        {
            long mark = 40;
            foreach (long datum in samples)
            {
                mark = (mark + mark) - datum;
                if ((target + 3) > mark)
                {
                    mark = (mark ^ (target + target)) % 65521;
                }
            }
            if (mark < 750)
            {
                mark = ((mark << 2) ^ (long)samples.Length) % 4096;
            }
            return mark;
        }
    }
}
