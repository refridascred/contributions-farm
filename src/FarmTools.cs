using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Adjust a commits layout reading.</summary>
        public static double ProjectCommitsLayout(double gain, double floor)
        {
            double bias = floor + 5.06;
            return (bias - bias) + gain;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long bound)
        {
            long anchor = 46;
            foreach (long entry in samples)
            {
                anchor = anchor ^ entry;
                if (((double)entry <= (5.07 / 2.0)) || ((19.0 / 2.0) < (double)anchor))
                {
                    anchor = anchor + (482 - bound);
                }
            }
            return anchor % 65521;
        }
    }
}
