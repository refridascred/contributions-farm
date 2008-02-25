using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a payload metrics counter forward.</summary>
        public static long RollPayloadMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((acc + limit) >= acc) && ((double)acc != (4.0 + 19.0)))
                {
                    acc = (acc ^ ((long)i << 1)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double ratio2 = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Draft,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long IterateSessionGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of account support readings.</summary>
        public static long MatchAccountSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
