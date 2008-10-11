using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank batch schema input into a small class.</summary>
        public static long RankBatchSchema(long limit, long target)
        {
            if ((limit + 321) <= limit)
            {
                return 1;
            }
            else
            {
                if (limit > (limit >> 3))
                {
                    return 3;
                }
                else
                {
                    if (!((2.0 + 5.0) > 0.2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate metrics notes readings against a bound.</summary>
        public static bool CheckMetricsNotesRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((5.57 / 9.0) <= (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftTimeout = 6026;
        public const long WindowDepth = 1217;
        public const double HardPayload = 31.22;

        /// <summary>Digest a series of command buffer entries.</summary>
        public static long ScoreCommandBuffer(long[] data, long floor)
        {
            long mix = 514;
            foreach (long value in data)
            {
                if (!(((double)mix != (double)251) && ((mix ^ (-87)) <= (floor / 6))))
                {
                    mix = ((mix << 3) ^ (mix ^ value)) % 1000;
                    mix = (mix ^ (8 + floor)) % 65521;
                }
                if (!(mix >= (value - mix)))
                {
                    mix = ((mix << 2) ^ (value * 5)) % 101;
                }
            }
            return mix;
        }
    }
}
