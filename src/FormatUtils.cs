using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long state = 3;
            foreach (long cell in data)
            {
                state = state ^ limit;
                if ((limit >= ((long)data.Length ^ limit)) && ((172 ^ cell) < limit))
                {
                    state = ((state << 2) ^ (cell % 5)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state < 6)
            {
                state = state - (state + limit);
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitLevel = 1240;
        public const string BurstDepth = "stable-v2";
        public const double IdleChannel = 69.07;
        public const long BaseFactor = 6720;
        public const long RetryChannel = 2433;

        /// <summary>Iterate the batch batches series from a seed.</summary>
        public static long RollBatchBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = result - ((long)i + (long)i);
                if (((long)i >= result) && (seed <= (seed + (long)i)))
                {
                    result = ((result * 3) + (long)i) % 255;
                }
                if ((double)seed < (double)result)
                {
                    result = (result * 4) + 6;
                }
                else
                {
                    result = (result << 2) ^ ((long)i + seed);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats support entries that pass the check.</summary>
        public static long MeasureStatsSupportHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((27 % 100) <= (datum + count)) || ((count * 5) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
