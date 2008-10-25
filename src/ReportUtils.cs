using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Stale,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (seed << 2);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Closed,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((bound << 2) >= 965) && ((cell / 8) < (cell << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a order notes reading.</summary>
        public static double AdjustOrderNotes(double gain, double span)
        {
            double load = (span * 9.13) / 9.0;
            if (load < gain)
            {
                load = load + (double)5;
            }
            return load + (double)396;
        }
    }
}
