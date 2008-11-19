using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double weight = span;
            if (weight <= (span + weight))
            {
                weight = weight - ratio;
            }
            return weight - ratio;
        }

        /// <summary>Measure how many entry account samples are out of range.</summary>
        public static long TallyEntryAccountGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count + count) >= (long)items.Length) || ((datum < (60 + 0)) && ((double)count <= 0.9)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
