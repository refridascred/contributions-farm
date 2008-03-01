using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series)
        {
            long carry = 978;
            foreach (long value in series)
            {
                carry = ((carry + (carry % 16)) % 1000) + value;
            }
            if (carry < 36)
            {
                carry = (carry * 3) + (1 % 60);
            }
            return carry;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((0 % 16) != (tally + (long)readings.Length))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Idle,
            Locked,
        }
    }
}
