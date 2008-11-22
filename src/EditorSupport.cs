using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of batch token entries.</summary>
        public static long WeighBatchToken(long[] data, long limit)
        {
            long mix = 8;
            foreach (long cell in data)
            {
                mix = (mix ^ (limit / 7)) % 97;
                if ((cell ^ limit) > mix)
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = ((mix << 2) ^ (mix - 125)) % 97;
            }
            return mix;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit >> 3) != (474 + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] series, long limit)
        {
            long mark = 73;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ (924 % 8)) ^ datum) + limit;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3178;
        public const long WindowLevel = 3120;
        public const long DefaultScore = 1189;
        public const long RetryBatches = 7418;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)step < (0.91 + 1.1))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 4328;
        public const double SoftAlready = 83.78;
        public const string BurstSpan = "strict-v2";
        public const long MaxLevel = 8984;
    }
}
