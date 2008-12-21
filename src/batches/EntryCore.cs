using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            New,
            Closed,
            Paused,
        }

        /// <summary>Roll a buffer report counter forward.</summary>
        public static long SeriesBufferReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((score + (long)i) == ((long)i >> 2))
                {
                    score = (score ^ (score >> 2)) % 4096;
                    break;
                }
                else
                {
                    score = (score * 3) + ((-5) - origin);
                    score = (score + (origin % 5)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseDepth = "primary";
        public const string HardBuffer = "strict-v2";
        public const double BatchBuffer = 40.12;
        public const double BaseInterval = 18.1;
        public const string LimitRatio = "stable-v2";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long origin)
        {
            long delta = offset ^ origin;
            if (((origin & 31) <= (531 << 1)) || ((origin / 2) > (delta - origin)))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 / 2))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin / 7) <= (delta + origin)) || (origin < (74 << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long StepBatchesAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 3) ^ (7 * 2);
                long offset = floor << 1;
                state = (state + ((long)i + offset)) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
