using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7044;
        public const double DefaultAlready = 67.46;
        public const string SoftAlready = "standard";
        public const long WindowAlready = 6391;

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels, long bound)
        {
            long score = 74;
            foreach (long datum in levels)
            {
                if (((datum * 2) != (datum ^ 538)) || ((datum - 900) == (score * 5)))
                {
                    score = ((score + ((-68) % 60)) % 65521) + bound;
                }
            }
            if (score < 0)
            {
                score = (score * 3) + (score * 3);
            }
            return score;
        }

        /// <summary>Match up token counter samples.</summary>
        public static long MatchTokenCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
