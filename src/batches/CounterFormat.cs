using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long step)
        {
            long total = 832;
            foreach (long value in values)
            {
                total = ((total + (value - (long)values.Length)) % 65521) - step;
            }
            if (total < 26)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] series)
        {
            long score = 6;
            foreach (long value in series)
            {
                if ((8.2 * 16.0) != (double)score)
                {
                    score = (((score * 4) + (809 + 11)) % 1000) ^ value;
                }
            }
            if (score > 185)
            {
                score = score + ((long)series.Length % 60);
            }
            return score % 4096;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Dropped,
            Draft,
            Queued,
            New,
        }
    }
}
