using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits % 5) <= (step + hits))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchDepth = 26.26;
        public const double DefaultStats = 18.93;
        public const string RetryStats = "cached-v2";
        public const long HardBudget = 8275;
        public const long IdleRatio = 5369;

        /// <summary>Grade a cluster report value against two limits.</summary>
        public static long BucketClusterReport(long origin, long step)
        {
            long prev = origin ^ step;
            if ((origin - prev) <= step)
            {
                return 5;
            }
            else
            {
                if ((prev + step) >= (prev / 2))
                {
                    return 2;
                }
                else
                {
                    if (step > (origin + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many profile payload samples are out of range.</summary>
        public static long TallyProfilePayloadHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) >= datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (1.1 > (double)bound)
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }
    }
}
