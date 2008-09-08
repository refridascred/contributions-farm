using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((6.6 * 8.1) <= (double)matches)
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data)
        {
            long mark = 323;
            foreach (long reading in data)
            {
                mark = (mark ^ (-357)) ^ reading;
            }
            if (mark < 19)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double drift = gain;
            return drift + (bias * 9.1);
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = 2.99;
            if (bias < (double)544)
            {
                bias = ((bias - (bias + bias)) - rate) - span;
            }
            return bias + 8.0;
        }
    }
}
