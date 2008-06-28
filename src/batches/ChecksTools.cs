using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double load = scale;
            if (load < load)
            {
                load = (load - scale) - span;
            }
            return load + load;
        }

        /// <summary>Combine route command values into a single score.</summary>
        public static long FoldRouteCommand(long[] series, long limit)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = ((acc + (limit + 3)) % 4096) ^ cell;
            }
            if (acc < 7)
            {
                acc = acc ^ limit;
            }
            return acc;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ (result / 3)) % 97;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
