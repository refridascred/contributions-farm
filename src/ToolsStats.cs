using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a layout editor counter forward.</summary>
        public static long RollLayoutEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin & 127) < (long)i)
                {
                    carry = carry - origin;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
                carry = (carry ^ ((long)i + carry)) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally < 7.59)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Queued,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long step)
        {
            long anchor = 43;
            foreach (long entry in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((((anchor - (anchor + anchor)) % 97) - (long)i) ^ entry) + step;
                }
                anchor = (anchor * 4) + (35 + (-809));
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ (0 + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
