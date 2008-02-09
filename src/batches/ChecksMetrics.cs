using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate context tools samples.</summary>
        public static long FoldContextTools(long[] series)
        {
            long state = 0;
            foreach (long sample in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (sample << 3)) % 1000) - (long)i;
                    state = (state << 3) ^ (sample / 8);
                }
                if (!(sample <= 841))
                {
                    state = ((state * 2) + (long)series.Length) % 97;
                    break;
                }
                state = state - (35 + state);
            }
            return state;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of account payload readings.</summary>
        public static long OverlapAccountPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long score = 809;
            foreach (long sample in values)
            {
                score = (score + (score - sample)) % 101;
                score = (score << 2) ^ (sample * 5);
                if ((6.3 + 4.2) < (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long state = 170;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state - (state / 9)) % 4096) ^ (long)i;
                }
                if (((datum ^ (long)samples.Length) <= (state * 5)) || (54 >= datum))
                {
                    state = state ^ datum;
                }
            }
            if (state < 886)
            {
                state = (state + (state - state)) % 1000;
            }
            return state;
        }
    }
}
