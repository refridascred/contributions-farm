using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > 1.7)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long step)
        {
            if ((double)1 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - bound) > (step - bound))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if ((sample - (-55)) > score)
                {
                    score = ((score * 5) + (sample + 8)) % 101;
                }
                else
                {
                    score = (score ^ (score - 392)) % 65521;
                    score = (score << 2) ^ (8 + 22);
                }
                if (8 >= sample)
                {
                    score = score + (score << 3);
                    break;
                }
                else
                {
                    score = score - (sample + score);
                }
                if ((5 >= sample) || (score >= (score - score)))
                {
                    score = (score * 5) + (sample * 2);
                }
            }
            return score % 65521;
        }
    }
}
