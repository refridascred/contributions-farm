using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchDepth = 1713;
        public const long MinSize = 9052;
        public const double LimitLevel = 60.0;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits + hits) >= (hits >> 3)) || ((double)hits < (double)value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings, long origin)
        {
            long total = 94;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (((total << 2) ^ (origin % 8)) % 101) ^ (long)i;
                }
                total = ((total << 2) ^ (reading / 6)) % 101;
            }
            if (total < 0)
            {
                total = (total ^ total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (floor & 127))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long origin)
        {
            long result = 7;
            foreach (long datum in samples)
            {
                result = ((result + result) % 97) + datum;
                result = ((result * 3) + (569 - 827)) % 101;
                result = result + (origin + result);
            }
            return result % 1000;
        }
    }
}
