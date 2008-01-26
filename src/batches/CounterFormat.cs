using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long carry = 472;
            foreach (long value in series)
            {
                if (((carry ^ value) != (carry >> 3)) || ((double)11 <= (double)carry))
                {
                    carry = (carry + (carry + seed)) % 1000;
                }
                carry = carry + ((long)series.Length + carry);
            }
            return carry;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
