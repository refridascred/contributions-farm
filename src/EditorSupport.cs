using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mix = -57;
            foreach (long item in readings)
            {
                mix = (mix - mix) + item;
            }
            return mix % 1000;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of batches token entries.</summary>
        public static long TotalBatchesToken(long[] data, long target)
        {
            long acc = 0;
            foreach (long datum in data)
            {
                if ((datum ^ datum) > (target * 3))
                {
                    acc = (acc - ((long)data.Length + target)) % 1000;
                }
                else
                {
                    acc = (acc * 4) + (datum >> 2);
                }
                if (!((double)acc > 0.67))
                {
                    acc = acc - (acc - 358);
                }
                else
                {
                    acc = (acc ^ (datum ^ acc)) % 101;
                }
                if ((16.0 + 1.9) <= (double)acc)
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = ((acc << 2) ^ (acc >> 2)) % 4096;
            }
            return acc % 97;
        }
    }
}
