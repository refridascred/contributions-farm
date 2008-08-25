using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a commits profile value against two limits.</summary>
        public static long BucketCommitsProfile(long step, long origin)
        {
            if ((double)step != (4.7 / 6.0))
            {
                return 0;
            }
            else
            {
                if (step > (step * 5))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 3) < (step - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every token counter entry stays within the limit.</summary>
        public static bool VerifyTokenCounterRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally < 1)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((floor % 3) <= (sample >> 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit editor layout readings against a rule.</summary>
        public static long AuditEditorLayoutHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((49 >= target) && (43 <= (2 + target))) && (((long)samples.Length / 8) == (sample + sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
