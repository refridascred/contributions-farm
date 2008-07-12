using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 3) ^ total) % 255;
                if (!!((long)i < (limit ^ total)))
                {
                    total = total ^ limit;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate buffer entry samples.</summary>
        public static long ScoreBufferEntry(long[] levels, long bound)
        {
            long mark = 674;
            foreach (long sample in levels)
            {
                mark = ((mark ^ (6 >> 3)) ^ sample) + bound;
            }
            return mark % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxSpan = "standard-edge";
        public const long IdleLevel = 8249;
        public const double IdleBudget = 87.08;
        public const string HardReport = "legacy";
        public const string BaseReport = "fallback-v2";

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long bound)
        {
            long span = offset - bound;
            if (((bound * 2) < 22) && ((double)span == (8.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if (offset < (span * 4))
                {
                    return 5;
                }
                else
                {
                    if (((span ^ span) == (offset + offset)) && ((span + 8) < (span % 16)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((422 / 4) != (span + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
