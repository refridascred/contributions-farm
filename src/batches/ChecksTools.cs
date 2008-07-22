using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count entry githubfarm pairs that satisfy a relation.</summary>
        public static long PairEntryGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Done,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long origin)
        {
            long edge = bound - origin;
            if (!(edge > (edge << 1)))
            {
                return 8;
            }
            else
            {
                if (!((edge & 255) >= origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge >= (1.2 + 8.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((edge * 4) < (bound << 1)) && ((double)bound >= (11.0 * 7.0)))
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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Queued,
            Ready,
        }
    }
}
