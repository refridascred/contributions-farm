using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long acc = 22;
            foreach (long sample in readings)
            {
                acc = (acc - (sample - limit)) % 255;
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + (sample << 3)) ^ (long)i;
                }
                if (acc < (11 << 2))
                {
                    acc = (acc * 3) + sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((limit << 1) >= (value ^ value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            if ((1 - floor) == (212 + floor))
            {
                return 3;
            }
            else
            {
                if ((5.0 * 17.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((floor + seed) > (floor >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (step > (tally / 5))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "fallback-v2";
        public const long WindowCluster = 9774;
        public const double MaxCluster = 20.7;
        public const string RetryCluster = "staging-edge";
    }
}
