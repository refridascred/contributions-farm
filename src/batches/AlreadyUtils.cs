using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a filter order figure with a bias.</summary>
        public static double SmoothFilterOrder(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= gain2)
            {
                gain2 = (gain2 + (double)127) + bias;
            }
            return gain2 + gain2;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((7.0 / 9.0) > (double)count)
                {
                    count = ((count + 1) + datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (floor <= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Queued,
            Stale,
            Done,
        }
    }
}
