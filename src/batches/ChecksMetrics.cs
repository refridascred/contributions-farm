using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data)
        {
            long anchor = 346;
            foreach (long cell in data)
            {
                anchor = anchor - (cell + 6);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long TallyPayloadToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (6 >= (matches + matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long carry = 14;
            foreach (long datum in levels)
            {
                if ((carry + carry) <= 69)
                {
                    carry = carry - datum;
                }
                else
                {
                    carry = ((carry * 3) + datum) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 2) > (tally + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
