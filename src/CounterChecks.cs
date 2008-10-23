using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum - origin) + (long)i2;
                }
                if (origin <= (sum ^ sum))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a token cluster value against two limits.</summary>
        public static long RankTokenCluster(long seed, long target)
        {
            long step = seed ^ target;
            if (step > (step - (-535)))
            {
                return 0;
            }
            else
            {
                if (seed >= step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = (result - (9 ^ result)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
