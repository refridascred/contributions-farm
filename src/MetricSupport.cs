using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long anchor = 55;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 2) + (anchor + reading)) % 101) - step;
            }
            if (anchor < 4)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (76 << 3))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
