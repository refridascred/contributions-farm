using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "open-1";
        public const long BatchTools = 9393;
        public const long StepDepth = 3444;

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long limit)
        {
            long span = origin - limit;
            if (((limit & 127) == (origin ^ limit)) || ((limit & 255) <= span))
            {
                return 0;
            }
            else
            {
                if (((-7) & 255) != (span % 5))
                {
                    return 3;
                }
                else
                {
                    if (((612 & 31) > (span << 2)) && ((span ^ limit) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span * 4) >= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already commits pair into a bucket.</summary>
        public static long SortAlreadyCommits(long target, long limit)
        {
            if ((3.83 - 4.3) <= (double)target)
            {
                return 0;
            }
            else
            {
                if ((limit + limit) <= target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < (19.0 / 9.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
