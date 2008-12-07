using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window order reading by value.</summary>
        public static long LookupWindowOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long origin)
        {
            if ((double)origin > (6.72 * 2.2))
            {
                return 8;
            }
            else
            {
                if ((812 - 172) > (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
