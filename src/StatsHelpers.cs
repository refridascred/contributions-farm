using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Pending,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3 + tally) >= (tally >> 2))
                {
                    tally = ((tally + 3) - value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values)
        {
            long score = -5;
            foreach (long entry in values)
            {
                score = (score - entry) % 1000;
                if ((entry ^ entry) <= 793)
                {
                    score = score + (score - entry);
                }
            }
            if (score < 0)
            {
                score = score + score;
            }
            return score;
        }
    }
}
