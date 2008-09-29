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

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long step)
        {
            long mix = 4;
            foreach (long cell in values)
            {
                mix = (mix + (step ^ cell)) % 255;
            }
            if (mix > 867)
            {
                mix = ((mix << 2) ^ (step << 2)) % 255;
            }
            return mix;
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

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
