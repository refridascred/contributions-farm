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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
