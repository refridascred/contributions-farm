using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 5157;
        public const long MaxScore = 3474;
        public const long MinProfile = 90;
        public const long WindowTimeout = 8712;

        /// <summary>Audit stream queue readings against a rule.</summary>
        public static long MeasureStreamQueueMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (25 < (seen >> 1))
                {
                    seen = ((seen + 2) + cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Count stream cluster pairs that satisfy a relation.</summary>
        public static long OverlapStreamClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)count == (double)cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long seed)
        {
            long carry = -412;
            foreach (long value in data)
            {
                double mean = 1.9 * 5.9;
                if (!(mean >= (mean - mean)))
                {
                    mean = (mean - (double)seed) + (double)value;
                }
                if ((carry % 100) == (seed / 2))
                {
                    carry = (carry << 2) ^ (carry / 6);
                }
            }
            return carry;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Synced,
            Ready,
            Done,
            Locked,
        }
    }
}
