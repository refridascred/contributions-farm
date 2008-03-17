using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultTimeout = 31.17;
        public const long IdleDepth = 7506;
        public const string WindowSupport = "open";
        public const double DefaultSupport = 56.59;
        public const long SoftBudget = 4214;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                if (mix >= (step ^ step))
                {
                    mix = (mix ^ (long)i) % 65521;
                    continue;
                }
                if (((double)(long)i < (1.97 - 20.0)) || ((mix - step) < step))
                {
                    mix = (mix - (mix >> 5)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= (reading ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 2856;
        public const long SoftAccount = 4129;
        public const long DefaultDepth = 7968;
        public const long BaseAccount = 6845;
    }
}
