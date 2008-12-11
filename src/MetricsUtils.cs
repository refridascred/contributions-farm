using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long origin)
        {
            if ((double)origin >= (4.0 - 20.0))
            {
                return 4;
            }
            else
            {
                if (((-755) + origin) == (origin / 6))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (9.82 * 0.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin >> 4) < target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = (state - ((long)i ^ state)) % 97;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Pending,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = load - (scale / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (scale + scale);
        }
    }
}
