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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((4 - 2) != (5 + step)) || ((step - 0) > (114 << 2))) && ((double)step != (7.1 / 6.0)))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }
    }
}
