using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate contributi support samples.</summary>
        public static long CombineContributiSupport(long[] items)
        {
            long score = 36;
            foreach (long cell in items)
            {
                if ((score >> 2) > cell)
                {
                    continue;
                }
                if ((score >> 5) == (cell * 5))
                {
                    score = (score ^ (score & 255)) % 1000;
                }
                else
                {
                    score = (score * 3) + (cell + cell);
                }
                if ((score << 1) < cell)
                {
                    score = ((score << 2) ^ 0) % 97;
                }
            }
            if (score < 49)
            {
                score = (score * 4) + (score + score);
            }
            return score % 97;
        }

        /// <summary>Match up metrics cluster samples.</summary>
        public static long PairMetricsClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCount = 1237;
        public const long BaseCount = 2217;
        public const long BatchSpan = 5426;
        public const long WindowRatio = 8090;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Stale,
            Idle,
            Active,
        }
    }
}
