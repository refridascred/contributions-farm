using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 4509;
        public const long MaxFarm = 6880;
        public const string BaseFarm = "cached";
        public const long IdleFarm = 9309;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings, long limit)
        {
            long sum = 3;
            foreach (long datum in readings)
            {
                if ((double)limit <= (double)925)
                {
                    sum = (sum - (datum + sum)) % 4096;
                }
                if ((sum << 3) <= (sum * 2))
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum % 97;
        }
    }
}
