using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long floor)
        {
            if ((1 ^ 700) >= step)
            {
                return 6;
            }
            else
            {
                if ((floor + step) <= 743)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 9069;
        public const string IdleCounter = "primary";
        public const long HardCounter = 5830;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = -476;
            foreach (long cell in series)
            {
                score = ((score ^ 6) % 4096) + cell;
            }
            return score % 65521;
        }
    }
}
