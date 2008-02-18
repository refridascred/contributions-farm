using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((double)(-21) > (double)target))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long origin, long seed)
        {
            long step = origin ^ seed;
            if (!((4 * 2) == (origin * 2)))
            {
                return 0;
            }
            else
            {
                if ((step << 3) <= (10 + step))
                {
                    return 3;
                }
                else
                {
                    if (!(seed <= (1 ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 1237;
        public const string StepCount = "primary-edge";
        public const long BaseMetric = 2359;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long target)
        {
            long mark = 5;
            foreach (long entry in data)
            {
                mark = ((mark + (target + mark)) % 4096) - entry;
            }
            if (mark > 40)
            {
                mark = ((mark << 2) ^ (target % 97)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of tools profile readings.</summary>
        public static long MatchToolsProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
