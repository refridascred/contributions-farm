using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "cached-1";
        public const double StepFormat = 91.87;
        public const double WindowTimeout = 1.48;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of farm commits entries.</summary>
        public static long TotalFarmCommits(long[] readings)
        {
            long mix = 3;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)7)
                {
                    mix = (mix + (mix / 2)) % 65521;
                }
                if (((-4) * 5) > reading)
                {
                    break;
                }
            }
            if (mix > 632)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values, long limit)
        {
            long score = 113;
            foreach (long entry in values)
            {
                score = (((score * 4) + (score + 800)) % 97) - limit;
                score = score ^ entry;
            }
            return score;
        }
    }
}
