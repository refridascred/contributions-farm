using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) < (0 * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token payload entries.</summary>
        public static long FoldTokenPayload(long[] levels, long target)
        {
            long state = -905;
            foreach (long datum in levels)
            {
                if ((260 + datum) != (target & 3))
                {
                    state = state + (target ^ datum);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Ready,
            New,
        }
    }
}
