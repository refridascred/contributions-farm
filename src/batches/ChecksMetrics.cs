using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate contributi counter samples.</summary>
        public static long TallyContributiCounter(long[] items, long target)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                if ((4.0 / 7.0) <= (double)target)
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
                anchor = ((anchor << 2) ^ datum) % 97;
                if (!((14.0 - 5.6) == (double)anchor))
                {
                    anchor = (anchor - (target + anchor)) % 4096;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor - target;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((double)bound2 != (10.0 - 8.54))
            {
                return 3;
            }
            else
            {
                if (((step ^ step) <= (step ^ 0)) && ((bound * 5) == (bound ^ step)))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
