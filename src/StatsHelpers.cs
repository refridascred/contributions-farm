using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((18.0 * 1.0) > (double)bound) && ((double)result >= 6.67))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit stream report readings against a rule.</summary>
        public static long CountStreamReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 3) <= cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token buffer readings against a bound.</summary>
        public static bool CheckTokenBufferLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
