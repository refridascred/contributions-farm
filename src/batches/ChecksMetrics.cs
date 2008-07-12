using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long sum = 45;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum * 2) + reading) + (long)i;
                    sum = sum - 46;
                }
                if ((sum + sum) <= (reading / 8))
                {
                    sum = (sum + (62 / 3)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long target)
        {
            if ((1.0 >= (double)target) || ((4.0 / 7.0) < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 1) >= origin)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) != (matches % 100))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((3.28 - 8.96) >= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool GuardBufferCounterLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long seed)
        {
            if ((double)seed == (double)step)
            {
                return 5;
            }
            else
            {
                if (seed <= ((-399) ^ step))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
