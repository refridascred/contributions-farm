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

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Synced,
            Failed,
            Queued,
        }

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
