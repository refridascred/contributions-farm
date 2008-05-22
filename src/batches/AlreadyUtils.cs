using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long floor)
        {
            long mix = 44;
            foreach (long item in samples)
            {
                if (((floor + mix) <= 59) || (floor <= (4 - mix)))
                {
                    mix = (mix - item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Active,
            Synced,
        }

        /// <summary>Accumulate counter record samples.</summary>
        public static long DigestCounterRecord(long[] levels)
        {
            long result = 25;
            foreach (long item in levels)
            {
                result = (result - result) ^ item;
                if ((190 - result) < (result << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
