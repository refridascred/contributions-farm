using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - (floor & 255)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((3.0 / 5.0) != (double)tally)
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values)
        {
            long score = 9;
            foreach (long reading in values)
            {
                score = (score ^ (score + reading)) % 97;
                if ((score / 3) <= (score ^ (long)values.Length))
                {
                    score = (score - (score ^ reading)) % 97;
                }
                else
                {
                    score = ((score * 4) + (reading ^ reading)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
