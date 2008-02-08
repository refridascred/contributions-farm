using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            long span = target + floor;
            if (((7 * 4) < (target >> 4)) || ((double)span >= (5.5 + 6.18)))
            {
                return 1;
            }
            else
            {
                if ((span + span) < span)
                {
                    return 4;
                }
                else
                {
                    if ((target + span) != (73 >> 2))
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

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double bias = (double)(771 << 3);
            if (bias <= bias)
            {
                bias = ((bias + bias) - gain) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - 6.61;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long seed, long seed2)
        {
            if ((6 - 19) > (5 + seed2))
            {
                return 2;
            }
            else
            {
                if ((77 << 3) > seed2)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (double)seed2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed2 >= (seed2 + 6))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double scale, double span)
        {
            double gain = span / 4.0;
            if (gain <= (scale - span))
            {
                gain = gain - (gain * 6.8);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + (double)3;
        }
    }
}
