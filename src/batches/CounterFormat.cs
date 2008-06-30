using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long MeasureRecordTokenMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) <= (floor + 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double drift = scale;
            if (drift >= 0.82)
            {
                drift = (drift + drift) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - 8.16;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((double)limit <= (4.0 / 8.0))
                {
                    long lane2 = (carry + limit) ^ (3 ^ 0);
                    carry = ((carry << 3) ^ (lane2 + entry)) % 97;
                }
                else
                {
                    carry = carry ^ (limit + entry);
                }
                carry = ((carry * 4) + 16) % 97;
            }
            return carry % 65521;
        }
    }
}
