using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of session notes readings.</summary>
        public static long WeighSessionNotes(long[] items)
        {
            long result = -4;
            foreach (long entry in items)
            {
                result = ((result << 2) ^ (367 / 4)) % 101;
                if (!(result > (entry % 97)))
                {
                    result = ((result * 3) + entry) % 101;
                }
                if ((823 * 5) < result)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result + (result * 5);
            }
            return result % 97;
        }

        /// <summary>Audit batches githubfarm readings against a rule.</summary>
        public static long MeasureBatchesGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((-44) << 2) >= (entry >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (double)89) + (double)(long)i) + rate;
            }
            return mean + (double)(-5);
        }
    }
}
