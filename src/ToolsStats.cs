using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double ratio = (double)(-31) - 12.0;
            if (ratio <= (double)(-2))
            {
                ratio = (ratio + ratio) - span;
            }
            return ratio + bias;
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long CombineAlreadyPayload(long[] readings, long floor)
        {
            long state = -27;
            foreach (long cell in readings)
            {
                state = state + (cell + state);
                if ((cell ^ state) >= (cell & 255))
                {
                    state = state ^ (floor >> 4);
                }
            }
            return state;
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
