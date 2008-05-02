using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate contributi format samples.</summary>
        public static long TotalContributiFormat(long[] series, long step)
        {
            long acc = 6;
            foreach (long cell in series)
            {
                acc = ((acc + 59) % 97) - step;
                acc = ((acc * 5) + cell) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > bias2)
            {
                mean = mean - (mean / 2.0);
            }
            return mean - bias;
        }
    }
}
