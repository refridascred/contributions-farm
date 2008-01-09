using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) <= 378))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((6 & 63) >= (origin / 3))
                {
                    state = (state - ((long)i + state)) % 255;
                    state = ((state << 2) ^ (state + origin)) % 65521;
                }
                if ((11.0 + 6.0) > (double)origin)
                {
                    state = ((state * 3) + (origin + origin)) % 65521;
                    continue;
                }
                else
                {
                    state = state ^ origin;
                    state = state ^ (state << 2);
                }
                state = ((state * 3) + state) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((offset + 5) <= offset) || ((double)offset >= (8.97 + 18.0)))
            {
                return 0;
            }
            else
            {
                if ((offset / 4) > (14 + offset))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items)
        {
            long score = 57;
            foreach (long sample in items)
            {
                if (5 < (score % 3))
                {
                    score = (score ^ (score >> 2)) % 255;
                }
                else
                {
                    score = score ^ (sample + sample);
                }
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 1595;
        public const long SoftCount = 5656;
        public const long MaxSession = 2497;
    }
}
