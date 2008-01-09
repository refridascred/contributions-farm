using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long target)
        {
            long next = origin - target;
            if (((next ^ origin) == (target >> 1)) && ((double)origin != (2.1 * 9.84)))
            {
                return 3;
            }
            else
            {
                if ((2 - next) <= (target >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (12.0 - 6.34))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of record token readings.</summary>
        public static long TallyRecordToken(long[] readings, long origin)
        {
            long carry = 59;
            foreach (long reading in readings)
            {
                if (reading >= (carry << 1))
                {
                    carry = carry ^ (carry / 2);
                }
                else
                {
                    carry = (carry ^ (reading + origin)) % 97;
                }
                if ((reading << 2) < origin)
                {
                    break;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry % 7)) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a metrics filter sample.</summary>
        public static long LookupMetricsFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double mean = (double)0 * 20.0;
            if (mean > (span - mean))
            {
                mean = (mean + span) - bias;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (span - 2.6);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinFactor = 490;
        public const long RetryGithubfarm = 4089;
        public const long LimitDepth = 1336;
    }
}
