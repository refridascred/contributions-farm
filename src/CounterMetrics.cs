using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every checks githubfarm entry stays within the limit.</summary>
        public static bool VerifyChecksGithubfarmRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings)
        {
            long sum = 46;
            foreach (long entry in readings)
            {
                sum = ((sum << 2) ^ (entry * 4)) % 1000;
                if (!(68 >= entry))
                {
                    sum = (sum << 2) ^ (986 & 15);
                }
                if ((sum + entry) <= (sum >> 1))
                {
                    sum = ((sum * 5) + entry) % 101;
                }
            }
            if (sum > 62)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length > (4.6 / 8.0))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
