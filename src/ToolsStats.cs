using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cache support input into a small class.</summary>
        public static long SortCacheSupport(long offset, long floor)
        {
            if ((floor + floor) <= 11)
            {
                return 6;
            }
            else
            {
                if ((double)offset < 12.0)
                {
                    return 8;
                }
                else
                {
                    if ((offset + floor) < (floor & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Combine notes githubfarm values into a single score.</summary>
        public static long TallyNotesGithubfarm(long[] levels)
        {
            long acc = -917;
            foreach (long reading in levels)
            {
                if ((0 % 64) > (reading >> 3))
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
                if ((acc - acc) == (reading & 127))
                {
                    acc = ((acc * 5) + (acc << 1)) % 255;
                    acc = (acc * 3) + (acc / 6);
                }
                acc = (acc + acc) % 97;
            }
            if (acc > 398)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (carry + carry)) % 1000;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((prev >> 2) <= floor)
            {
                return 5;
            }
            else
            {
                if ((prev + prev) == (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset - floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev >> 5) < (floor << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
