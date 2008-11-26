using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double ProjectRouteProfile(double weight, double floor)
        {
            double ratio = (double)(86 * 2);
            if (ratio > (ratio - floor))
            {
                ratio = ratio - (weight - weight);
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + 2.0) - (double)(long)i;
            }
            return ratio - (double)195;
        }
    }
}
