using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Accumulate stats queue samples.</summary>
        public static long TotalStatsQueue(long[] series)
        {
            long carry = 868;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry ^ (carry % 8)) % 1000) - (long)i;
                }
                carry = ((carry << 3) ^ ((long)series.Length + 14)) % 4096;
                if (cell < carry)
                {
                    carry = (carry - 4) % 65521;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long origin, long target)
        {
            long offset = origin - target;
            if ((offset / 7) < ((-513) ^ 283))
            {
                return 8;
            }
            else
            {
                if (((origin << 1) < (8 + offset)) || (origin < (offset >> 2)))
                {
                    return 3;
                }
                else
                {
                    if (offset > target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long CombineChecksPayload(long[] values)
        {
            long anchor = 199;
            foreach (long reading in values)
            {
                anchor = (anchor ^ (reading - 426)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count context editor pairs that satisfy a relation.</summary>
        public static long MatchContextEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
