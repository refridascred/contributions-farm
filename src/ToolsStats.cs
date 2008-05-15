using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftLevel = 34.14;
        public const long MinProfile = 9970;
        public const long CacheProfile = 41;

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

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double drift = bias;
            if (drift > (span / 9.0))
            {
                drift = drift + drift;
            }
            return drift + (drift - 15.0);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((-950) + result) >= (floor - result))
                {
                    result = ((result * 5) + (floor * 2)) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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
