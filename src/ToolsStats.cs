using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Closed,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long TotalFarmChecks(long[] series)
        {
            long anchor = 84;
            foreach (long cell in series)
            {
                if ((189 ^ cell) == (0 & 255))
                {
                    anchor = anchor ^ (anchor * 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels)
        {
            long anchor = 2;
            foreach (long cell in levels)
            {
                if (cell >= (cell << 2))
                {
                    anchor = (anchor ^ (cell + (-92))) % 1000;
                }
            }
            if (anchor > 965)
            {
                anchor = (anchor * 5) + (anchor << 2);
            }
            return anchor;
        }
    }
}
