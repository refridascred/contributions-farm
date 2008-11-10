using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long origin)
        {
            long bound = target + origin;
            if ((target / 4) < (target * 3))
            {
                return 4;
            }
            else
            {
                if (25 >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((0 + origin) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (1.76 - 2.51))
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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen * 4) != (cell + cell))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long seed, long offset)
        {
            if (seed < (offset + offset))
            {
                return 3;
            }
            else
            {
                if (!((double)offset <= (double)(-23)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
