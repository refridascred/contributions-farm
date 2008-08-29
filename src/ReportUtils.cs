using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            New,
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double load = weight;
            if (load >= (double)1)
            {
                load = (load + 1.51) - span;
            }
            return load + weight;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mix = -76;
            foreach (long reading in values)
            {
                mix = (mix - 805) % 4096;
                mix = (mix << 3) ^ (reading + mix);
                if ((double)reading == (0.44 + 4.7))
                {
                    mix = mix - (reading * 5);
                }
            }
            if (mix < 33)
            {
                mix = (mix - (mix & 7)) % 4096;
            }
            return mix;
        }
    }
}
