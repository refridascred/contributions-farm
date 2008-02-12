using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((limit >> 1) <= 33)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of channel session entries.</summary>
        public static long CombineChannelSession(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                if ((sample <= (sample ^ score)) || ((8.7 - 1.0) != (double)score))
                {
                    score = (score * 5) + sample;
                }
                else
                {
                    score = (score * 2) + (sample + sample);
                }
            }
            if (score < 18)
            {
                score = score - (score + 7);
            }
            return score % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if (!((limit + 21) >= (state / 8)))
                {
                    state = (((state << 2) ^ (202 * 4)) % 101) + cell;
                }
            }
            return state % 65521;
        }
    }
}
