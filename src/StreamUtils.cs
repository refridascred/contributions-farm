using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Audit metrics context readings against a rule.</summary>
        public static long CountMetricsContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 2) != (9 >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i ^ (long)i) != ((long)i % 8))
                {
                    mix = (mix * 3) + (mix - mix);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate format profile readings against a bound.</summary>
        public static bool ValidateFormatProfileLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
