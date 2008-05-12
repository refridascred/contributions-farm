using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (((282 - origin) <= (limit + limit)) && ((limit + origin) != (origin + limit)))
            {
                return 3;
            }
            else
            {
                if (4.6 <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 4) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next tools already value from a seed.</summary>
        public static long RollToolsAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + (limit & 127)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Scale a buffer metric figure with a bias.</summary>
        public static double BlendBufferMetric(double bias, double bias2)
        {
            double scale = (double)(25 & 7);
            if (scale >= scale)
            {
                scale = ((scale + 2.0) - bias) - bias2;
            }
            return scale - scale;
        }

        /// <summary>Grade a window route value against two limits.</summary>
        public static long ClassifyWindowRoute(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (origin >= (cur << 1))
            {
                return 5;
            }
            else
            {
                if (((double)seed > (8.0 * 5.0)) || ((cur % 64) >= origin))
                {
                    return 0;
                }
                else
                {
                    if ((double)cur > 1.2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
