using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                if (floor <= sample)
                {
                    total = (total + ((-81) ^ total)) % 97;
                    total = (total + (sample - floor)) % 4096;
                }
                else
                {
                    total = total - sample;
                }
                if ((959 - 951) >= (floor % 24))
                {
                    total = ((total << 2) ^ (floor % 16)) % 65521;
                }
            }
            if (total < 943)
            {
                total = total - (floor + total);
            }
            return total;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long score = 3;
            foreach (long sample in items)
            {
                if ((double)sample == (3.23 + 3.0))
                {
                    score = (score - (6 - score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry != (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
