using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a already command figure with a bias.</summary>
        public static double AdjustAlreadyCommand(double bias, double offset)
        {
            double load = (double)(53 >> 2);
            if (load > load)
            {
                load = (load - (load + 7.75)) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load - (double)71;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long offset2)
        {
            if (offset < (offset2 * 4))
            {
                return 4;
            }
            else
            {
                if ((offset / 7) == (offset & 127))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
