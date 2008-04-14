using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double bias)
        {
            double weight = bias - (13.0 / 9.0);
            if (weight <= (weight - gain))
            {
                weight = weight - (4.06 / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
