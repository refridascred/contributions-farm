using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the checks githubfarm series from a seed.</summary>
        public static long RollChecksGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= 17.0)
            {
                gain = gain - (ratio / 9.0);
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain - span;
        }
    }
}
