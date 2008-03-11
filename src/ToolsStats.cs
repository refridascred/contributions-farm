using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of report editor entries.</summary>
        public static long ScoreReportEditor(long[] readings, long offset)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                carry = ((carry * 2) + (offset ^ carry)) - reading;
            }
            return carry;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Idle,
            New,
            Queued,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)seen <= (9.28 + 5.2)) || ((double)seen == (17.0 * 9.75)))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long gap = offset + offset2;
            if (89 >= gap)
            {
                return 4;
            }
            else
            {
                if ((offset > (offset2 * 3)) || (offset2 > (gap % 64)))
                {
                    return 1;
                }
                else
                {
                    if (gap < (162 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
