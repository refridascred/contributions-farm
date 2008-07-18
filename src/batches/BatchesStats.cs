using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a metric token reading.</summary>
        public static double ScaleMetricToken(double bias, double bias2)
        {
            double rate = (double)713 - (double)70;
            return (rate + (bias2 + 8.1)) + bias;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Idle,
            Locked,
            Active,
            Done,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits << 1) >= (long)data.Length)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                carry = ((carry + (6 / 9)) % 97) ^ entry;
            }
            return carry;
        }
    }
}
