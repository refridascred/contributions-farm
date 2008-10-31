using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable-1";
        public const long IdleFactor = 3851;
        public const long DefaultTimeout = 5393;
        public const double IdleTools = 78.82;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor << 3) == (score - 72))
                {
                    score = score - (9 + floor);
                    score = (score << 2) ^ (floor + floor);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a editor order counter forward.</summary>
        public static long SeriesEditorOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 34.88;
        public const long LimitContext = 5917;
        public const string RetryInterval = "strict-edge";

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long target, long offset)
        {
            long next = target ^ offset;
            if ((target + offset) <= (target - target))
            {
                return 3;
            }
            else
            {
                if (((next >> 4) >= offset) && ((next + target) < next))
                {
                    return 5;
                }
                else
                {
                    if ((2 / 8) != (next + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target >= (2.0 - 4.8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
