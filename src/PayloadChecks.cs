using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                if (95 < (item ^ item))
                {
                    anchor = (anchor - (item + (-3))) % 97;
                    continue;
                }
                if ((9.0 + 15.0) <= (double)item)
                {
                    anchor = ((anchor * 5) + (anchor << 2)) % 255;
                }
                else
                {
                    anchor = anchor ^ ((-4) - anchor);
                }
            }
            if (anchor > (-956))
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if ((floor2 & 15) >= floor2)
            {
                return 2;
            }
            else
            {
                if ((8.17 * 1.41) <= (double)floor2)
                {
                    return 8;
                }
                else
                {
                    if ((floor2 / 5) > slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double gain = span;
            if (gain < scale)
            {
                gain = gain - gain;
            }
            return gain - (8.5 - span);
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long AuditToolsAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 2) <= (long)values.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
