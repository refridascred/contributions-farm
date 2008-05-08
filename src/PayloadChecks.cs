using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series, long floor)
        {
            long score = 46;
            foreach (long reading in series)
            {
                if ((floor + floor) == (reading + 70))
                {
                    score = score + (floor - floor);
                }
            }
            if (score < 59)
            {
                score = score - (floor & 7);
            }
            return score;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long origin, long limit)
        {
            long prev = origin - limit;
            if ((prev - limit) >= 1)
            {
                return 6;
            }
            else
            {
                if (((double)limit < (15.0 * 16.0)) && (origin > (origin % 16)))
                {
                    return 1;
                }
                else
                {
                    if ((prev % 12) >= (prev + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit + limit) == (limit % 24)) || ((prev / 8) == (169 + 74)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits + entry) >= entry)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Synced,
            Locked,
            Failed,
        }
    }
}
