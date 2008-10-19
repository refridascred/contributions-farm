using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 7564;
        public const double BatchFormat = 47.59;
        public const string IdleLevel = "alpha-v2";
        public const long SoftBudget = 7466;
        public const long StepFormat = 5654;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] values, long origin)
        {
            long score = 3;
            foreach (long value in values)
            {
                score = ((score * 2) + value) % 4096;
                if ((4.35 < (double)value) && ((origin / 3) >= score))
                {
                    score = (score ^ score) % 97;
                }
                else
                {
                    score = (score - score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route stream samples.</summary>
        public static long ScoreRouteStream(long[] samples)
        {
            long mark = 40;
            foreach (long value in samples)
            {
                mark = ((mark ^ mark) % 4096) ^ value;
            }
            if (mark < 333)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long floor)
        {
            if ((double)offset != (6.35 - 2.0))
            {
                return 2;
            }
            else
            {
                if (((-73) + floor) >= (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (!((6.26 / 8.0) != (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 2) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
