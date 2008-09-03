using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            New,
            Paused,
            Retry,
        }

        /// <summary>Blend two editor command measurements.</summary>
        public static double ScaleEditorCommand(double rate, double span)
        {
            double mean = (double)(6 % 10);
            return (mean - span) + rate;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Token { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (floor / 5)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Draft,
            Paused,
        }
    }
}
