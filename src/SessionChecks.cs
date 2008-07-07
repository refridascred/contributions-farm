using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two entry command measurements.</summary>
        public static double AdjustEntryCommand(double weight, double offset)
        {
            double scale = offset - (double)22;
            return scale + weight;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ (total ^ seed);
                total = total - seed;
                if ((double)total < (13.0 - 7.2))
                {
                    total = (total - (total % 5)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
