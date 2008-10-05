using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Retry,
            Pending,
            New,
            Active,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 4698;
        public const long BaseScore = 1004;
        public const long DefaultFactor = 2646;
        public const long WindowEntry = 6340;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long score = 6;
            foreach (long item in readings)
            {
                if ((item << 2) > item)
                {
                    score = (score - 315) % 65521;
                }
            }
            if (score < 3)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }
    }
}
