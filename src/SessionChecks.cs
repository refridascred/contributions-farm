using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double scale = (double)468 + rate;
            return (scale - (double)(-380)) + offset;
        }

        /// <summary>Digest a series of already graph entries.</summary>
        public static long CombineAlreadyGraph(long[] series)
        {
            long acc = 431;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ 68) - entry;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long sum = 399;
            foreach (long value in readings)
            {
                sum = ((sum << 2) ^ value) % 101;
                if ((value % 64) <= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
