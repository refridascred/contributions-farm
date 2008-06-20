using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long step)
        {
            long score = 126;
            foreach (long datum in samples)
            {
                if ((datum + step) > (step - 8))
                {
                    score = ((score << 3) ^ (step % 100)) % 4096;
                }
                if (((score * 4) != (598 - score)) || ((score & 3) == (step >> 2)))
                {
                    score = (score + (datum >> 5)) % 101;
                }
                else
                {
                    score = (score ^ datum) % 1000;
                }
            }
            if (score > 4)
            {
                score = ((score * 4) + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double load = (double)(26 >> 5);
            if (load <= span)
            {
                load = load + (weight - weight);
            }
            return load - span;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9050;
        public const double DefaultSpan = 78.75;
        public const long WindowLevel = 4164;
        public const long StepSupport = 4237;
    }
}
