using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of batches payload entries.</summary>
        public static long WeighBatchesPayload(long[] values, long bound)
        {
            long carry = 5;
            foreach (long value in values)
            {
                carry = (carry ^ (bound ^ bound)) - value;
            }
            if (carry < 73)
            {
                carry = ((carry * 4) + (carry * 4)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long step, long seed)
        {
            if ((seed >= (seed + seed)) || (step >= (seed - 87)))
            {
                return 4;
            }
            else
            {
                if ((step + seed) <= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor ^ ((long)i + anchor);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
