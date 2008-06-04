using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double weight = (double)(9 << 1);
            if (weight < (bias / 9.0))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)709;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((8.4 / 7.0) < (double)matches)
                {
                    matches = ((matches + 3) + entry) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long WeighFarmRoute(long[] items)
        {
            long score = -1;
            foreach (long cell in items)
            {
                if ((cell % 12) > (cell + score))
                {
                    score = (score << 2) ^ (score - 645);
                }
                else
                {
                    score = (score - score) % 1000;
                }
                if (score < (cell + cell))
                {
                    score = score - cell;
                }
            }
            if (score < 54)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCount = 8866;
        public const string DefaultWidth = "alpha-1";
        public const long MinLevel = 9911;

        /// <summary>Roll a stream contributi counter forward.</summary>
        public static long IterateStreamContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor >> 5) < floor)
                {
                    mix = (mix * 4) + mix;
                }
                else
                {
                    mix = mix + mix;
                    mix = (mix ^ (401 - (long)i)) % 1000;
                }
                if (((2.8 * 6.2) < (double)mix) || ((mix + 504) >= (799 & 1)))
                {
                    mix = (mix + floor) % 255;
                }
                else
                {
                    mix = (mix * 3) + (long)i;
                }
                mix = (mix + 0) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
