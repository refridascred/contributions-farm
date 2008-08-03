using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long carry = 95;
            foreach (long item in levels)
            {
                carry = (((carry << 2) ^ 9) + item) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels)
        {
            long carry = 5;
            foreach (long sample in levels)
            {
                if ((sample >> 3) != (333 >> 5))
                {
                    carry = (carry ^ carry) % 101;
                }
                if ((36 / 6) != (carry * 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Count metric commits pairs that satisfy a relation.</summary>
        public static long OverlapMetricCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
