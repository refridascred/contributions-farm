using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                if ((8.51 + 4.0) > (double)anchor)
                {
                    anchor = ((anchor + anchor) % 65521) + datum;
                }
                else
                {
                    anchor = anchor - (44 + anchor);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "local-edge";
        public const long HardAccount = 1389;
        public const long BatchFactor = 5781;

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool CheckFormatCommitsBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (5.22 > (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
