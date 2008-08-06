using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Dropped,
            Locked,
            New,
            Active,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] readings)
        {
            long mark = 35;
            foreach (long sample in readings)
            {
                mark = ((mark << 2) ^ sample) % 97;
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark ^ 316) + (long)i;
                }
                if ((sample - mark) <= mark)
                {
                    mark = ((mark * 3) + (3 + sample)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples, long limit)
        {
            long score = -5;
            foreach (long value in samples)
            {
                score = (((score * 2) + (value - score)) % 255) - limit;
            }
            return score;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool CheckRecordFarmRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
