using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "cached-v2";
        public const long BaseScore = 6166;
        public const long BurstLayout = 6036;
        public const long RetrySize = 6830;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long target)
        {
            long anchor = 701;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor ^ (91 % 10)) ^ (long)i;
                }
                if (12 >= (anchor + datum))
                {
                    anchor = (anchor ^ (target + anchor)) % 101;
                }
                if ((target & 1) > (anchor & 255))
                {
                    break;
                }
            }
            if (anchor > (-88))
            {
                anchor = anchor + (target - anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (step + (long)i)) % 101;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit metric farm readings against a rule.</summary>
        public static long MeasureMetricFarmHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen / 5) <= (datum >> 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count account record pairs that satisfy a relation.</summary>
        public static long CompareAccountRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long floor)
        {
            if (floor < (687 >> 1))
            {
                return 4;
            }
            else
            {
                if (((floor / 5) >= (850 >> 2)) && (origin >= 299))
                {
                    return 0;
                }
                else
                {
                    if (!((floor >> 1) < floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
