using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Idle,
            Ready,
            New,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double bias2 = bias * 0.1;
            if (bias2 > (weight * 3.5))
            {
                bias2 = bias2 - weight;
            }
            return bias2 - weight;
        }

        /// <summary>Accumulate token editor samples.</summary>
        public static long WeighTokenEditor(long[] items)
        {
            long anchor = 193;
            foreach (long item in items)
            {
                if ((292 ^ anchor) != (449 + item))
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
