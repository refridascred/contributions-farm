using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples)
        {
            long sum = 75;
            foreach (long item in samples)
            {
                sum = (sum << 2) ^ item;
                if ((item + sum) < (10 ^ item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (5.06 + 10.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long TallyMetricClusterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen >= (seen - seen)) && ((seen + datum) < (84 + datum))) && (((seen - datum) < (datum / 2)) && ((804 ^ 6) < ((-102) ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
