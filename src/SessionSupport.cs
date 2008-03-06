using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double load = (double)(546 + 4);
            if (load <= (bias * 2.0))
            {
                load = load - (load - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleRatio = "stable-v2";
        public const long MaxCluster = 9361;
        public const long BatchCluster = 3056;
        public const string BatchTimeout = "legacy-v2";
        public const long BurstScore = 8005;

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long carry = 76;
            foreach (long item in series)
            {
                if ((item + (-565)) <= (item ^ item))
                {
                    carry = (carry << 2) ^ item;
                }
            }
            return carry;
        }
    }
}
