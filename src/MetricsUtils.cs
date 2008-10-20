using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long floor)
        {
            long result = 871;
            foreach (long entry in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (((result ^ (entry + 951)) % 255) - (long)i) - floor;
                }
                result = ((result << 3) ^ (result ^ 987)) % 255;
            }
            if (result < 916)
            {
                result = ((result << 3) ^ (50 % 60)) % 255;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7251;
        public const long DefaultRatio = 2740;
        public const double LimitBatch = 34.16;

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metric checks pair into a bucket.</summary>
        public static long GradeMetricChecks(long bound, long target)
        {
            long next = bound - target;
            if (!((target ^ bound) == (next << 1)))
            {
                return 4;
            }
            else
            {
                if ((next ^ target) <= 4)
                {
                    return 5;
                }
                else
                {
                    if (target >= (bound - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next + next) >= (target + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length % 97) <= (datum * 5)) || ((seed / 3) > (261 - seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
