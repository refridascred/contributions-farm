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

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long offset, long target)
        {
            if ((double)target >= 9.1)
            {
                return 2;
            }
            else
            {
                if ((target < offset) || ((double)5 == (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
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
