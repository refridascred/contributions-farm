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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
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

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long sum = 171;
            foreach (long entry in readings)
            {
                if ((entry & 1) <= (81 & 63))
                {
                    sum = ((sum << 2) ^ (entry - 686)) % 65521;
                }
                else
                {
                    sum = (sum ^ (7 + floor)) % 1000;
                }
            }
            return sum;
        }
    }
}
