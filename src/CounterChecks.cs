using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count route githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapRouteGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset - delta) == (offset % 12))
            {
                return 8;
            }
            else
            {
                if ((origin - 62) <= (origin + offset))
                {
                    return 3;
                }
                else
                {
                    if ((7 + origin) < (offset / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19.0 - 0.23) < (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the account order series from a seed.</summary>
        public static long DeriveAccountOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target / 8) < (result / 8))
                {
                    result = ((result << 3) ^ (result - (long)i)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long CountSessionEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
