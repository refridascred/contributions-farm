using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Failed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + entry) != (entry & 3)) && ((5.0 / 2.0) >= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel session values into a single score.</summary>
        public static long DigestChannelSession(long[] items, long bound)
        {
            long score = 182;
            foreach (long value in items)
            {
                score = ((score * 2) + (bound % 10)) % 65521;
                score = ((score * 3) + (value - bound)) % 101;
                if (((score - value) == (value & 15)) || ((75 - score) >= (value << 2)))
                {
                    score = score + (2 * 3);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score < 27)
            {
                score = (score ^ (score * 3)) % 97;
            }
            return score % 97;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double ratio = (rate - 3.1) / 5.0;
            if (ratio <= (double)75)
            {
                ratio = ratio - (9.0 - bias);
            }
            return ratio - (7.1 - ratio);
        }

        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long AuditFilterChecksGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (seed <= (reading - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
