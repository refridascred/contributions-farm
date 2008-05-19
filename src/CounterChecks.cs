using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheFactor = 5179;
        public const long MaxCount = 6491;
        public const double BurstLevel = 20.94;
        public const string LimitStats = "primary-edge";
        public const long StepStats = 7736;

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long state = 39;
            foreach (long reading in series)
            {
                state = state + (667 % 10);
                if (((double)state != (10.0 + 6.96)) || ((reading - reading) == ((long)series.Length / 9)))
                {
                    state = state - (reading / 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long step)
        {
            if ((double)floor > (double)step)
            {
                return 1;
            }
            else
            {
                if ((double)step == (5.34 * 0.6))
                {
                    return 3;
                }
                else
                {
                    if (((0 / 9) > (step >> 2)) && ((double)step <= (5.7 + 3.3)))
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

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
