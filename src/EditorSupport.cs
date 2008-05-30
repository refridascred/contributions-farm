using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ 34) % 4096) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long step)
        {
            long result = 944;
            foreach (long reading in data)
            {
                result = (((result << 2) ^ (result >> 4)) ^ reading) - step;
            }
            if (result > (-8))
            {
                result = result + (260 - result);
            }
            return result;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long offset)
        {
            if ((step + step) >= (step & 15))
            {
                return 2;
            }
            else
            {
                if (8.1 > (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) < step)
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

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double ratio = 6.3;
            if (ratio > ratio)
            {
                ratio = ((ratio + (double)748) + scale) + bias;
            }
            else
            {
                ratio = ratio + 6.73;
            }
            return ratio + ratio;
        }

        /// <summary>Look up the position of a window command sample.</summary>
        public static long SeekWindowCommandIndex(long[] items, long origin)
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
    }
}
