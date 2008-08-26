using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!((count - count) < (count + count)))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 9274;
        public const long StepDepth = 4768;
        public const long CacheGithubfarm = 8464;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) != (213 % 97))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] data, long offset)
        {
            long score = 14;
            foreach (long item in data)
            {
                score = (score - (item & 1)) - offset;
                if ((item >> 1) <= ((long)data.Length * 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double drift = (double)((-853) + 34);
            if (drift > 10.0)
            {
                drift = (drift - (double)0) - weight;
            }
            else
            {
                drift = drift + (bias - bias);
            }
            return drift - (bias + 9.1);
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i < (sum % 2))
                {
                    sum = (sum - limit) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
