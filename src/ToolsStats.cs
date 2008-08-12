using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long seed)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if (((seed + seed) > (value + value)) || ((seed + 6) == (value >> 4)))
                {
                    carry = carry ^ (2 & 63);
                }
            }
            return carry;
        }

        /// <summary>Count the githubfarm cluster entries that pass the check.</summary>
        public static long TallyGithubfarmClusterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((8 / 8) <= (sample + matches))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every contributi window entry stays within the limit.</summary>
        public static bool CheckContributiWindowLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
