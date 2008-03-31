using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate session context readings against a bound.</summary>
        public static bool CheckSessionContextBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 78.54;
        public const double WindowCount = 8.29;
        public const string MaxTimeout = "strict-1";
        public const long CacheWidth = 7967;

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)anchor <= (double)step))
                {
                    anchor = (anchor + (step & 31)) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long step)
        {
            long sum = 778;
            foreach (long value in samples)
            {
                sum = ((sum * 5) + step) + value;
            }
            return sum;
        }

        /// <summary>Grade a channel githubfarm value against two limits.</summary>
        public static long ClassifyChannelGithubfarm(long seed, long limit)
        {
            if ((limit / 3) <= (seed << 3))
            {
                return 5;
            }
            else
            {
                if ((limit & 31) <= (seed % 16))
                {
                    return 0;
                }
                else
                {
                    if (((seed + seed) >= seed) && (((-88) / 4) > (limit & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit > (limit % 7)))
                        {
                            return 3;
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
