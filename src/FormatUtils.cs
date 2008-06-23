using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!!(((long)i * 3) != (94 ^ (long)i)))
                {
                    acc = (acc - (acc + (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every githubfarm order entry stays within the limit.</summary>
        public static bool CheckGithubfarmOrderLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score - (-140)) % 101;
                score = ((score * 5) + (bound - bound)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (target & 15)) % 4096;
                state = state + state;
                if (((state + 2) != (597 + 954)) || ((89 & 127) <= (state - state)))
                {
                    state = ((state << 3) ^ (5 + target)) % 97;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ (anchor >> 2)) % 1000;
                if (9.7 < (double)(long)i)
                {
                    anchor = ((anchor * 3) + (anchor + anchor)) % 101;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
