using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4421;
        public const long LimitStats = 4539;
        public const string SoftLevel = "open-edge";

        /// <summary>Measure how many format command samples are out of range.</summary>
        public static long AuditFormatCommandOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry * 5) >= tally) || (entry <= (entry ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading <= (733 << 2)) || ((seen + reading) == (seen % 16)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long seed)
        {
            long delta = limit - seed;
            if (!((limit % 24) <= (delta ^ delta)))
            {
                return 5;
            }
            else
            {
                if (seed >= (limit / 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
