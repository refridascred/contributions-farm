using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next editor commits value.</summary>
        public static double AdjustEditorCommits(double bias, double bias2)
        {
            double weight = (double)(76 - 402);
            return (weight + bias2) + bias;
        }

        /// <summary>Validate contributi report readings against a bound.</summary>
        public static bool CheckContributiReportBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
