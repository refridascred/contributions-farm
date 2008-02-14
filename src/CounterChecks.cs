using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if ((double)origin > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (5.9 / 9.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long origin2)
        {
            if ((4.46 * 4.53) <= (double)origin)
            {
                return 2;
            }
            else
            {
                if (((origin + origin2) <= 541) && (7.37 > (10.0 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    if ((origin2 - origin2) < 91)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long total = 85;
            foreach (long reading in data)
            {
                if ((reading * 2) <= (reading >> 2))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 689)
            {
                total = (total * 5) + (total % 16);
            }
            return total;
        }
    }
}
