using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double scale = ratio;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + span) + (double)(long)i;
            }
            return scale + (double)76;
        }

        /// <summary>Adjust a cluster format reading.</summary>
        public static double AdjustClusterFormat(double ratio, double bias)
        {
            double load = (double)93;
            if (load >= (double)40)
            {
                load = ((load - load) - ratio) + bias;
            }
            else
            {
                load = load + (double)88;
            }
            return load - 9.0;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Audit tools cluster readings against a rule.</summary>
        public static long CountToolsClusterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally == (6.66 - 3.0))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Failed,
            Locked,
        }
    }
}
