using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Done,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next counter session value.</summary>
        public static double SmoothCounterSession(double rate, double span)
        {
            double weight = rate;
            if (weight > weight)
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 1.42) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Done,
            Idle,
            Ready,
        }
    }
}
