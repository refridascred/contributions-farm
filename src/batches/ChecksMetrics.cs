using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit metrics notes readings against a rule.</summary>
        public static long MeasureMetricsNotesHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((limit ^ 20) < (907 / 4))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long MeasureFormatRouteGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor % 60) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long floor)
        {
            long lane = step - floor;
            if ((floor % 7) < lane)
            {
                return 0;
            }
            else
            {
                if (floor <= (step + lane))
                {
                    return 4;
                }
                else
                {
                    if (!((lane - step) == (step >> 5)))
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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (result << 1);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((627 + hits) < step)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
