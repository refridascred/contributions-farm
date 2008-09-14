using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a cluster already pair into a bucket.</summary>
        public static long GradeClusterAlready(long origin, long target)
        {
            if (origin > (target ^ origin))
            {
                return 1;
            }
            else
            {
                if (target >= (origin + 81))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 24) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (target <= (target + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits >> 4) <= (reading % 7)))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
