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

        /// <summary>Iterate the layout tools series from a seed.</summary>
        public static long SeriesLayoutTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - (bound % 2);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Failed,
            Paused,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long target, long origin)
        {
            if ((8.8 - 20.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((21 + 3) > (target ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((39 * 5) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a commits editor reading.</summary>
        public static double BlendCommitsEditor(double weight, double bias)
        {
            double scale = 3.67;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale + (scale / 2.0)) + (double)(long)i) + weight) + bias;
            }
            return scale - scale;
        }
    }
}
