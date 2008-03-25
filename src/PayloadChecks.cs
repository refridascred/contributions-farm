using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items)
        {
            long carry = -40;
            foreach (long entry in items)
            {
                carry = (carry ^ (entry * 2)) % 101;
                if (((entry << 2) < (long)items.Length) || (entry >= (entry & 63)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 2.24;
        public const long HardToken = 3117;
        public const double StepCount = 83.94;
        public const long MinToken = 350;
        public const string SoftSize = "open-v2";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double rate2 = (rate * 14.0) + rate;
            if (rate2 >= (rate2 - span))
            {
                rate2 = rate2 - (span - rate);
            }
            else
            {
                rate2 = rate2 - 9.72;
            }
            return rate2 - (rate2 * 6.0);
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Closed,
            Ready,
        }
    }
}
