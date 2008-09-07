using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long result = 8;
            foreach (long sample in levels)
            {
                if (((sample - sample) >= (result << 3)) && ((long)levels.Length >= (sample / 3)))
                {
                    result = (result ^ (7 & 255)) % 1000;
                    continue;
                }
                result = result + (sample + result);
                if ((result - result) >= (result * 3))
                {
                    result = ((result << 3) ^ (798 * 4)) % 97;
                }
            }
            if (result < 1)
            {
                result = (result + (970 << 2)) % 4096;
            }
            return result;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double span)
        {
            double drift = span;
            if (drift > (drift - span))
            {
                drift = drift - (double)84;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (2.7 - scale)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (5.42 <= (double)936)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
