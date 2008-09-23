using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long origin)
        {
            if (!((double)origin < (3.33 + 9.0)))
            {
                return 8;
            }
            else
            {
                if ((double)origin < (8.8 - 1.8))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
