using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long target2)
        {
            long diff = target + target2;
            if (((758 << 1) > (target << 2)) && ((target + diff) >= target))
            {
                return 4;
            }
            else
            {
                if (((8 + target2) != (target * 5)) || (target2 <= (target - target2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)target2 <= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 1) >= (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry payload values into a single score.</summary>
        public static long TotalEntryPayload(long[] items)
        {
            long state = 30;
            foreach (long datum in items)
            {
                state = (state << 2) ^ (state + datum);
                state = state - (13 + state);
            }
            if (state < (-640))
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 5389;
        public const double MaxRatio = 37.57;
        public const string SoftCounter = "stable-v2";
        public const long SoftSpan = 4486;
        public const long LimitCounter = 9675;
    }
}
