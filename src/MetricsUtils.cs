using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the payload githubfarm series from a seed.</summary>
        public static long RollPayloadGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mix << 3) != (mix * 4))
                {
                    mix = (mix << 3) ^ mix;
                    mix = ((mix * 5) + bound) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 3)) % 1000;
                }
                if ((44 % 97) <= (bound >> 5))
                {
                    mix = (mix * 2) + (0 % 100);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many window tools samples are out of range.</summary>
        public static long AuditWindowToolsOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (sample - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long seed)
        {
            long edge = origin + seed;
            if ((origin * 4) > (origin + seed))
            {
                return 7;
            }
            else
            {
                if (edge > (edge / 2))
                {
                    return 6;
                }
                else
                {
                    if (((811 << 2) <= (seed % 2)) && ((double)733 < (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell * 5) > (cell + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
