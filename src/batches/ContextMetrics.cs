using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor ^ mix) > (floor - 88))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels, long target)
        {
            long carry = 557;
            foreach (long entry in levels)
            {
                carry = ((carry - (target ^ carry)) % 255) + entry;
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1059;
        public const long LimitSchema = 3533;
        public const double DefaultSchema = 37.89;
        public const long BatchSchema = 1227;
        public const long StepSchema = 4830;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long anchor = 18;
            foreach (long reading in data)
            {
                if ((1.0 > (double)(long)data.Length) || (((long)data.Length ^ step) <= step))
                {
                    anchor = (anchor - (reading >> 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor - reading)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
