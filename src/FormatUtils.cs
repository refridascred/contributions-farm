using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many account record samples are out of range.</summary>
        public static long CountAccountRecordOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (step < (55 ^ (-71)))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue channel samples.</summary>
        public static long FoldQueueChannel(long[] readings)
        {
            long result = 628;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (93 % 60)) % 255) - (long)i;
                }
                if ((result + result) <= result)
                {
                    result = (result ^ (1 ^ cell)) % 1000;
                }
                else
                {
                    result = result + cell;
                }
            }
            return result;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double rate = 10.0;
            return ((rate - 0.06) + weight) + offset;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = mix - (mix - origin);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
