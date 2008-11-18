using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long score = 54;
            foreach (long entry in readings)
            {
                if ((score / 5) <= (score - entry))
                {
                    score = score + score;
                }
            }
            if (score < 36)
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double gain = (double)(6 + 3);
            return ((gain + 4.2) + scale) + span;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double scale = gain;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (span * 9.0)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
