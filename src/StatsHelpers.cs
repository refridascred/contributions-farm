using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long AuditBatchesSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ (long)data.Length) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] data, long offset)
        {
            long total = 81;
            foreach (long datum in data)
            {
                total = (((total ^ (total - total)) % 4096) + datum) - offset;
            }
            if (total < 8)
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Locked,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Compare every pair of metric payload readings.</summary>
        public static long CompareMetricPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
