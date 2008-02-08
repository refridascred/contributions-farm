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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((17.0 + 1.58) < (double)bound2)
            {
                return 7;
            }
            else
            {
                if (seed <= (seed + bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 127) >= seed) || ((seed % 100) > bound2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((2.0 - 6.82) == (double)bound2) && (seed < (1 & 15)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
