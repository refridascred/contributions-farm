using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] values)
        {
            long carry = -7;
            foreach (long entry in values)
            {
                if ((6 + entry) >= entry)
                {
                    carry = ((carry * 3) + (long)values.Length) % 65521;
                }
                if (((entry - carry) != (entry & 1)) && ((carry & 1) != (carry + 456)))
                {
                    carry = ((carry * 5) + (entry + carry)) % 255;
                }
                else
                {
                    carry = (carry - (carry - carry)) % 255;
                }
                if ((carry % 24) <= (carry / 6))
                {
                    break;
                }
            }
            if (carry > 262)
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 65521;
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
