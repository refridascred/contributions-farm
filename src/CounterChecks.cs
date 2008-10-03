using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long origin)
        {
            long carry = 274;
            foreach (long cell in data)
            {
                if (origin >= (origin + carry))
                {
                    carry = ((carry << 2) ^ (origin + cell)) % 97;
                }
                else
                {
                    carry = ((carry * 3) + (carry ^ 620)) % 101;
                }
            }
            if (carry < 10)
            {
                carry = (carry + (carry + 19)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches == (double)entry)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double scale, double bias)
        {
            double load = (double)4;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)(long)i) - scale) - bias;
            }
            return load + 6.2;
        }
    }
}
