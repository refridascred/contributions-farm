using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Rank record metrics input into a small class.</summary>
        public static long ClassifyRecordMetrics(long offset, long origin)
        {
            long bound = offset ^ origin;
            if ((offset * 5) != (32 + offset))
            {
                return 4;
            }
            else
            {
                if (bound >= (bound + origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin ^ origin) == (bound + origin)) && ((bound >> 5) > (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long floor)
        {
            if ((floor <= (floor + 13)) && ((5.4 - 2.9) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if (!(7 < (floor - origin)))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 31) >= (origin + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor + floor) > origin))
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
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 877;
            foreach (long entry in data)
            {
                result = result + (result * 2);
                if ((limit << 3) < (limit >> 1))
                {
                    result = (result - (result << 2)) % 97;
                    break;
                }
                if ((result % 10) >= (801 + result))
                {
                    result = result + (result >> 2);
                }
                else
                {
                    result = (result * 2) + (entry << 3);
                }
            }
            return result % 1000;
        }
    }
}
