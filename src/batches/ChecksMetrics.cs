using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i / 8) > (limit % 7))
                {
                    score = (score ^ ((long)i - limit)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count session window pairs that satisfy a relation.</summary>
        public static long MatchSessionWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepDepth = "fallback-edge";
        public const long MaxBudget = 4439;
        public const string StepMetrics = "primary-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleInterval = 2883;
        public const long StepCluster = 7947;
        public const long LimitLevel = 3307;
        public const double BaseCluster = 70.43;
        public const long LimitCluster = 8502;
    }
}
