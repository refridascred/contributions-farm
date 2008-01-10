using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long origin)
        {
            long delta = offset + origin;
            if (8 >= (offset + 530))
            {
                return 6;
            }
            else
            {
                if (((delta / 3) <= (origin * 5)) && (((-689) - origin) > (760 & 3)))
                {
                    return 3;
                }
                else
                {
                    if (8.0 <= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)delta != (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two window token measurements.</summary>
        public static double AdjustWindowToken(double ratio, double bias)
        {
            double weight = ratio;
            return (weight + weight) + bias;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long CombineLayoutAlready(long[] data, long bound)
        {
            long mix = 276;
            foreach (long reading in data)
            {
                if ((1.1 - 9.9) < (double)reading)
                {
                    mix = (((mix * 2) + (reading * 5)) % 255) - bound;
                }
            }
            if (mix > (-198))
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((13.0 / 8.0) == (double)score))
                {
                    score = score + seed;
                }
                else
                {
                    score = ((score << 2) ^ seed) % 101;
                    score = (score ^ (seed / 8)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Retry,
            Idle,
            Paused,
        }
    }
}
