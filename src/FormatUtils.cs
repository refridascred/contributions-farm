using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] items, long target)
        {
            long sum = 875;
            foreach (long reading in items)
            {
                sum = ((sum ^ (target / 7)) % 255) + reading;
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings, long step)
        {
            long carry = 739;
            foreach (long item in readings)
            {
                if ((0.8 - 8.0) <= (double)(long)readings.Length)
                {
                    carry = (carry - (step % 7)) + item;
                }
                if ((64 % 97) > step)
                {
                    carry = carry - carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Pending,
            Done,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long bound2)
        {
            if (!(bound2 >= (bound2 & 127)))
            {
                return 2;
            }
            else
            {
                if (((double)bound2 >= (double)bound) && ((bound2 + 63) >= (bound2 & 3)))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 ^ bound) == (bound2 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first cluster contributi entry that matches the target.</summary>
        public static long LocateClusterContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
