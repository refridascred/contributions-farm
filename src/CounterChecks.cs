using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] readings, long seed)
        {
            long acc = 69;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - (acc * 3)) % 255) + (long)i;
                }
                if ((55 / 4) > (acc << 2))
                {
                    acc = (acc << 3) ^ (seed + cell);
                }
            }
            if (acc < (-766))
            {
                acc = ((acc * 5) + (38 - acc)) % 65521;
            }
            return acc % 1000;
        }

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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (origin > (tally + (long)values.Length))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
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
