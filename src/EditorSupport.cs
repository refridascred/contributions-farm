using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((double)seed < (0.6 + 1.0))
            {
                return 3;
            }
            else
            {
                if (1.13 >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (seed >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed << 2) > (bound - seed)) || ((17.0 * 4.3) != (double)seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window metric figure with a bias.</summary>
        public static double SmoothWindowMetric(double ratio, double floor)
        {
            double bias = (ratio - ratio) * 16.0;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - ratio) - (double)(long)i) - floor;
            }
            return bias + (ratio + ratio);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if (bound < (bound >> 4))
            {
                return 2;
            }
            else
            {
                if ((origin > (bound * 2)) || ((bound & 7) > (bound + 257)))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > 1.93) || ((origin * 5) > (origin % 24)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (2.46 + 5.4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command farm readings against a rule.</summary>
        public static long AuditCommandFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally > (6 & 63))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
