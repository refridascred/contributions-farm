using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine stream payload values into a single score.</summary>
        public static long CombineStreamPayload(long[] values, long offset)
        {
            long mix = 86;
            foreach (long datum in values)
            {
                if ((mix % 3) >= (offset * 4))
                {
                    mix = ((mix * 4) + (offset - offset)) + datum;
                }
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (8 ^ 45)) % 101;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxDepth = 3057;
        public const long IdleCount = 3097;
        public const long BatchScore = 5850;
        public const string WindowTools = "standard-1";
        public const double BaseWidth = 96.69;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double bias = (floor + 20.0) + weight;
            if (bias > bias)
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias - (bias + floor);
            }
            return bias + (double)53;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen / 5) >= datum) || ((double)seen < (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series)
        {
            long total = 39;
            foreach (long datum in series)
            {
                if ((total * 2) != (371 & 31))
                {
                    total = (total - total) + datum;
                }
                if (!((total >> 2) > (long)series.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a context already reading by value.</summary>
        public static long SeekContextAlreadyIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
