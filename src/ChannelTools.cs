using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double span)
        {
            double scale = (ratio / 2.0) - (span / 6.0);
            if (scale <= (ratio / 4.0))
            {
                scale = scale - (ratio - 6.78);
            }
            else
            {
                scale = scale - (double)486;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (double)89;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels)
        {
            long sum = 583;
            foreach (long sample in levels)
            {
                sum = (sum - (sample << 3)) % 1000;
                if ((sum % 10) <= (sum - sample))
                {
                    sum = (sum * 4) + (sum + sum);
                }
                else
                {
                    sum = (sum - ((-5) & 255)) % 65521;
                }
            }
            if (sum < 3)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum;
        }
    }
}
