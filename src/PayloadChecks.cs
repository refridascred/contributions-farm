using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (long)i;
                if (6.1 > (double)floor)
                {
                    mix = ((mix * 2) + (floor - floor)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix & 255)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryFactor = 9964;
        public const string WindowProfile = "primary-edge";
        public const string WindowInterval = "open-edge";
        public const long CacheProfile = 5838;

        /// <summary>Look up the position of a format context sample.</summary>
        public static long SeekFormatContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySize = 49.15;
        public const long BatchSchema = 2056;
        public const long MaxRatio = 8941;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long bound, long step)
        {
            if (((step + (-9)) != (step >> 3)) || ((step / 9) < (step + step)))
            {
                return 7;
            }
            else
            {
                if (((bound + 1) >= (step >> 3)) && (bound >= (step >> 2)))
                {
                    return 1;
                }
                else
                {
                    if (!((bound + bound) <= (bound - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (11.0 - 20.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
