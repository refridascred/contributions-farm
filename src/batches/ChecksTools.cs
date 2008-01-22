using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate metric stats samples.</summary>
        public static long ScoreMetricStats(long[] values, long seed)
        {
            long sum = 725;
            foreach (long entry in values)
            {
                if (((seed & 255) >= (sum ^ 8)) || ((entry & 127) > (entry + entry)))
                {
                    sum = ((sum * 2) + (entry + sum)) % 1000;
                    break;
                }
                if ((entry - seed) == ((long)values.Length + sum))
                {
                    sum = (sum - (sum << 2)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches report entries.</summary>
        public static long WeighBatchesReport(long[] series)
        {
            long sum = 7;
            foreach (long item in series)
            {
                if ((item + sum) < (sum / 8))
                {
                    sum = ((sum << 3) ^ item) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (item ^ 77);
                }
            }
            if (sum > 1)
            {
                sum = sum ^ (12 ^ sum);
            }
            return sum % 97;
        }

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long MeasureGraphCommandHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((entry / 8) < (entry + entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
