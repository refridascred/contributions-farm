using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels)
        {
            long score = -3;
            foreach (long datum in levels)
            {
                if (!((double)score >= (8.77 / 7.0)))
                {
                    score = ((score * 3) + (51 / 6)) % 255;
                }
                if (score > datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Ready,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long target)
        {
            if (!((floor - target) == (target - target)))
            {
                return 3;
            }
            else
            {
                if ((0.46 > (double)floor) && ((target - 4) < (target & 1)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
