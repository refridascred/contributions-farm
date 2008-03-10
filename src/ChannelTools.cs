using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items, long limit)
        {
            long score = 87;
            foreach (long cell in items)
            {
                score = ((score + (score + cell)) % 101) - limit;
                if (cell < score)
                {
                    score = ((score * 4) + (0 & 255)) % 101;
                }
            }
            if (score > 5)
            {
                score = ((score * 5) + (score + score)) % 4096;
            }
            return score;
        }
    }
}
