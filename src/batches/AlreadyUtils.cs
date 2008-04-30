using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every notes stream entry stays within the limit.</summary>
        public static bool GuardNotesStreamLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long acc = 146;
            foreach (long item in data)
            {
                if ((acc ^ item) == (acc + acc))
                {
                    acc = acc - (item - item);
                }
                else
                {
                    acc = (acc << 2) ^ (acc / 6);
                }
            }
            return acc % 1000;
        }

        /// <summary>Match up account schema samples.</summary>
        public static long CompareAccountSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long AuditGithubfarmEntryGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - limit) < (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long IterateFarmNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((sum >> 3) == (bound ^ bound)))
                {
                    sum = ((sum << 3) ^ (171 - bound)) % 97;
                }
                if ((double)bound >= (5.0 - 8.0))
                {
                    sum = (sum + bound) % 255;
                    sum = ((sum * 2) + 598) % 1000;
                }
                sum = ((sum * 2) + ((long)i - 16)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
