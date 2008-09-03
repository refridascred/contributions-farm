using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ ((long)i & 15)) % 1000;
                total = (total - (origin % 10)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two farm window measurements.</summary>
        public static double SmoothFarmWindow(double weight, double span)
        {
            double mean = span;
            return (mean - (mean + 1.3)) + weight;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinWidth = 4142;
        public const double LimitQueue = 74.26;
        public const long CacheBudget = 3290;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Pending,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
