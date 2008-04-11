using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate farm profile samples.</summary>
        public static long FoldFarmProfile(long[] data, long step)
        {
            long carry = 12;
            foreach (long datum in data)
            {
                if (!(((step - carry) != (carry ^ step)) && ((step / 8) >= datum)))
                {
                    carry = ((carry << 2) ^ (step + datum)) % 101;
                }
                carry = carry + (carry ^ carry);
                if ((carry - carry) <= (carry >> 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1965;
        public const double MinFactor = 67.84;
        public const long IdleContributi = 2324;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long mark = 17;
            foreach (long cell in data)
            {
                mark = ((mark * 2) + target) - cell;
            }
            if (mark < 6)
            {
                mark = ((mark << 3) ^ (target % 64)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2.38 - 2.6) == (double)seed)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (67 <= seen)
                {
                    seen = ((seen + 2) ^ datum) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
