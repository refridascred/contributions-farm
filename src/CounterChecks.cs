using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window metrics readings against a rule.</summary>
        public static long MeasureWindowMetricsOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length >= floor)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long TallyWindowMetricsMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((origin > (count << 1)) || ((double)origin < (6.1 + 1.0))) && (((74 - 7) <= (count * 3)) || (datum >= origin)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Token { get; set; } = "";
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long step, long floor)
        {
            long diff = step ^ floor;
            if (!(step <= (floor / 6)))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((double)diff <= (5.2 + 18.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((10.0 - 1.85) > (double)diff) || ((diff + step) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "cached-edge";
        public const double MaxBatches = 59.36;
        public const long LimitBatches = 641;
        public const long DefaultBatches = 5663;
        public const long MinBatches = 5429;
    }
}
