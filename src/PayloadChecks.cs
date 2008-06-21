using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data, long bound)
        {
            long mix = 66;
            foreach (long datum in data)
            {
                mix = ((mix - (mix - mix)) ^ datum) + bound;
            }
            return mix % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxWidth = "fallback-edge";
        public const long LimitAlready = 8507;
        public const long WindowSpan = 614;
        public const double MinScore = 91.45;
        public const long MinRatio = 3430;

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double floor)
        {
            double ratio2 = 1.0;
            if (ratio2 > floor)
            {
                ratio2 = ratio2 - (ratio * 9.87);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "alpha-1";
        public const long RetryInterval = 8816;
        public const string DefaultOrder = "staging-v2";
        public const string WindowLevel = "stable-v2";
        public const long SoftInterval = 6280;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double bias = offset;
            if (bias <= 8.8)
            {
                bias = (bias + (double)8) - weight;
            }
            else
            {
                bias = bias + offset;
            }
            return bias + (offset - bias);
        }

        /// <summary>Audit commits format readings against a rule.</summary>
        public static long TallyCommitsFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (3 <= (count ^ reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
