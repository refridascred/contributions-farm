using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Retry,
            Dropped,
            New,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 5) <= (entry / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double bias)
        {
            double load = bias;
            if (load < load)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (double)70;
            }
            return load - (9.6 * 6.3);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long limit)
        {
            long carry = 33;
            foreach (long item in series)
            {
                carry = (carry - limit) % 255;
                carry = (carry * 5) + (item - limit);
            }
            return carry;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
