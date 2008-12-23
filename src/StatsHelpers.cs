using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate session account samples.</summary>
        public static long TallySessionAccount(long[] data, long limit)
        {
            long mark = 95;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum >> 2)) % 4096;
            }
            if (mark < (-65))
            {
                mark = mark + limit;
            }
            return mark;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Retry,
            Failed,
            Active,
        }
    }
}
