using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double scale = floor;
            return scale - (rate - floor);
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long bound, long limit)
        {
            long bound2 = bound + limit;
            if (((-89) + bound) > (limit << 1))
            {
                return 0;
            }
            else
            {
                if (((509 & 63) > (limit >> 4)) && ((7 & 15) > (bound2 - bound)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound + bound) != (limit + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - limit) <= (848 ^ 22))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long target)
        {
            if (!((7.4 * 4.2) >= (double)bound))
            {
                return 3;
            }
            else
            {
                if (((3.84 / 3.0) != (double)target) || ((9.31 * 1.0) >= (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((target % 8) <= (target / 2)) && ((bound + 983) <= bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((7 - bound) == (51 ^ target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((332 % 12) < ((long)samples.Length ^ datum)))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit queue editor readings against a rule.</summary>
        public static long TallyQueueEditorMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((9.41 * 2.51) >= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
