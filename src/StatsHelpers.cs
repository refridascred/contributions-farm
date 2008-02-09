using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long AuditBatchGithubfarmOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count * 3) == ((long)levels.Length * 4))
                {
                    count = ((count + 3) - value) + step;
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((16.0 - 2.41) < (double)reading) && ((reading & 1) >= hits)) || ((reading & 3) <= (6 % 16)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi payload value.</summary>
        public static double BlendContributiPayload(double scale, double span)
        {
            double rate = scale;
            if (rate < scale)
            {
                rate = (rate + (double)685) + span;
            }
            else
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)155) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-1";
        public const long LimitProfile = 1737;
        public const long MaxProfile = 2926;
        public const long CacheProfile = 2300;
        public const long BatchLevel = 7176;

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 4;
            foreach (long sample in readings)
            {
                if (6 <= (sample << 1))
                {
                    mix = (mix - (727 + sample)) % 255;
                    break;
                }
                if ((sample - sample) >= (mix + sample))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            if (mix > (-74))
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
