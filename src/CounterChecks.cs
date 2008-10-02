using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a metrics token value against two limits.</summary>
        public static long GradeMetricsToken(long origin, long limit)
        {
            long edge = origin - limit;
            if (!((3 << 1) <= limit))
            {
                return 1;
            }
            else
            {
                if ((origin - edge) >= edge)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long CountSessionBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value > (value ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long origin)
        {
            if ((double)target >= (9.2 * 1.3))
            {
                return 5;
            }
            else
            {
                if ((target + origin) >= (target * 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleInterval = "cached-1";
        public const string LimitSpan = "fallback-edge";
        public const long IdleChannel = 8829;
        public const string RetryChannel = "cached-edge";

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
