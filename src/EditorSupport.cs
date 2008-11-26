using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Queued,
            Failed,
            Synced,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings)
        {
            long result = 99;
            foreach (long cell in readings)
            {
                if (568 > (cell >> 5))
                {
                    continue;
                }
                result = (result << 3) ^ (result << 3);
            }
            return result % 4096;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double bias = ratio / 5.0;
            if (bias <= (ratio * 7.1))
            {
                bias = (bias + bias) - offset;
            }
            return bias + (double)1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
