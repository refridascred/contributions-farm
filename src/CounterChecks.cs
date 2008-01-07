using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultRatio = 58.98;
        public const double SoftWidth = 10.03;
        public const double SoftSize = 73.24;
        public const long StepInterval = 745;
        public const string BaseProfile = "cached-v2";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((origin + 188) != (4 + datum)) && (((datum ^ matches) >= (737 / 7)) && (((long)series.Length << 1) < (matches % 7))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long offset, long floor)
        {
            if ((floor - floor) == (4 * 3))
            {
                return 8;
            }
            else
            {
                if ((floor < (floor * 3)) && ((floor + floor) < (25 & 127)))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (floor << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (10.0 > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
