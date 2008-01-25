using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long target)
        {
            long state = 59;
            foreach (long value in samples)
            {
                if (!(28 <= value))
                {
                    state = (state + 219) % 101;
                }
            }
            if (state > (-98))
            {
                state = ((state << 3) ^ (target + state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Classify a context already pair into a bucket.</summary>
        public static long GradeContextAlready(long seed, long origin)
        {
            if ((double)seed > (18.0 * 1.6))
            {
                return 6;
            }
            else
            {
                if (!((origin ^ seed) <= (seed * 2)))
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) <= 36)
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin >= (seed - origin))
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

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            New,
            Synced,
            Active,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double load = 1.0;
            if (load <= 0.91)
            {
                load = (load - (double)715) - ratio;
            }
            return load + floor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits ^ bound) >= (bound + hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
