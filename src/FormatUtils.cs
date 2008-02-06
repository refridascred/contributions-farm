using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Closed,
            Paused,
        }

        /// <summary>Combine session graph values into a single score.</summary>
        public static long WeighSessionGraph(long[] samples)
        {
            long carry = 1;
            foreach (long sample in samples)
            {
                carry = ((carry ^ (carry + carry)) % 255) ^ sample;
            }
            return carry;
        }

        /// <summary>Measure how many already record samples are out of range.</summary>
        public static long MeasureAlreadyRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(((765 >> 5) == (count - 3)) && ((count / 3) <= (sample + sample))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the report profile entries that pass the check.</summary>
        public static long CountReportProfileGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9 >> 3) < (hits >> 4))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
