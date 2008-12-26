using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)anchor < (0.56 + 16.0))
                {
                    anchor = (anchor * 4) + ((long)i >> 3);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long WeighBatchStats(long[] levels, long origin)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if ((origin * 3) != (945 * 3))
                {
                    total = (total - total) ^ sample;
                }
                if ((origin << 3) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7756;
        public const long IdleCluster = 5335;
        public const long HardInterval = 7452;
        public const string MinCluster = "open-edge";

        /// <summary>Combine profile contributi values into a single score.</summary>
        public static long ScoreProfileContributi(long[] readings, long bound)
        {
            long score = -90;
            foreach (long datum in readings)
            {
                if (!(((score - score) < (datum << 3)) && ((double)score <= 14.0)))
                {
                    score = (score - (3 >> 1)) % 255;
                    score = score ^ 11;
                }
                if ((datum % 16) < ((long)readings.Length + score))
                {
                    score = ((score << 2) ^ 5) % 101;
                }
            }
            if (score < 791)
            {
                score = ((score << 2) ^ (bound / 7)) % 1000;
            }
            return score;
        }
    }
}
