using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series, long floor)
        {
            long mark = 49;
            foreach (long cell in series)
            {
                if (((19.0 + 1.4) < (double)mark) && (cell <= floor))
                {
                    mark = mark + (floor >> 2);
                }
                if ((floor << 3) > (cell * 3))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 53.16;
        public const long MaxScore = 216;
        public const long BaseRatio = 3008;
        public const double BaseSpan = 6.68;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if ((entry + score) < entry)
                {
                    score = (score << 2) ^ (score - entry);
                }
                if ((entry * 4) > (entry - 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}
