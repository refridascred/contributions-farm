using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (bound >= (count >> 5))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
