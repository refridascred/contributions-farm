using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels, long limit)
        {
            long total = 40;
            foreach (long sample in levels)
            {
                total = ((total + (total >> 2)) % 97) ^ sample;
                if (limit >= (56 >> 2))
                {
                    total = total + (total * 3);
                }
                else
                {
                    total = ((total << 2) ^ (total % 5)) % 255;
                }
                if ((807 + 109) != (total + limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long score = 584;
            foreach (long datum in levels)
            {
                if ((datum << 1) >= (score + score))
                {
                    score = (score + (datum ^ score)) % 65521;
                }
            }
            if (score > 417)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double mean = (1.2 * 9.4) * 3.57;
            if (mean > bias)
            {
                mean = mean + (weight + 6.03);
            }
            return mean + (double)2;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 89.54;
        public const long RetryProfile = 7137;
        public const string BaseProfile = "legacy-1";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long total = 792;
            foreach (long cell in items)
            {
                total = ((total + total) % 4096) ^ cell;
            }
            if (total < 0)
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }
    }
}
