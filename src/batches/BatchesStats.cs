using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long mix = 2;
            foreach (long item in items)
            {
                mix = (((mix * 5) + (mix % 10)) % 1000) ^ item;
            }
            return mix;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Locked,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long bound)
        {
            long acc = 6;
            foreach (long entry in data)
            {
                if ((7.0 - 8.93) > (double)(long)data.Length)
                {
                    acc = (acc + (acc & 127)) % 97;
                }
                else
                {
                    acc = (acc ^ (acc % 12)) % 97;
                }
                if (!((0.6 * 4.66) != (double)acc))
                {
                    acc = ((acc << 2) ^ (entry + bound)) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Failed,
            Pending,
            Draft,
            New,
        }
    }
}
