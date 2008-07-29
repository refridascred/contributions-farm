using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            if ((double)floor < (double)428)
            {
                return 0;
            }
            else
            {
                if ((bound / 4) > (7 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (1.0 < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((743 / 3) >= (bound << 2)) || ((6.0 * 1.3) >= (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long result = -501;
            foreach (long cell in samples)
            {
                result = ((result * 4) + 873) ^ cell;
            }
            return result % 4096;
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
