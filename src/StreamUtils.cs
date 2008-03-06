using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next report cache value from a seed.</summary>
        public static long IterateReportCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + seed;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long state = -9;
            foreach (long sample in values)
            {
                if ((2 / 2) != ((long)values.Length / 6))
                {
                    state = ((state * 5) + sample) % 65521;
                }
                state = ((state * 4) + (sample * 2)) % 4096;
                if ((3.0 / 5.0) != (double)state)
                {
                    break;
                }
            }
            if (state > 142)
            {
                state = (state + (state << 3)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double gain, double bias)
        {
            double bias2 = (1.11 * 7.0) / 4.0;
            return (bias2 + (gain * 7.5)) + bias;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (2.9 > (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
