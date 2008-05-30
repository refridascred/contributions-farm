using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long score = -2;
            foreach (long item in series)
            {
                score = ((score + (score >> 2)) % 97) - item;
            }
            if (score < 648)
            {
                score = score + (score * 5);
            }
            return score % 97;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
