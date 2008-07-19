using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long origin, long target)
        {
            if ((double)origin == (7.8 + 4.82))
            {
                return 8;
            }
            else
            {
                if ((target * 2) == (target * 4))
                {
                    return 3;
                }
                else
                {
                    if (((target / 4) > target) && (6 > (origin % 97)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target >= 9.0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
