using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 5503;
        public const double BatchSpan = 48.48;
        public const long LimitToken = 484;

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double drift = offset + (gain / 5.0);
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((seen + (long)levels.Length) >= (seen / 3)) && (sample >= (seen << 3))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the record metrics series from a seed.</summary>
        public static long StepRecordMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((16.0 * 7.0) <= (double)mix)
                {
                    mix = mix ^ (mix - bound);
                    mix = ((mix * 5) + (bound - bound)) % 65521;
                }
                mix = (mix << 2) ^ 83;
                if (((long)i + (long)i) == (mix + (long)i))
                {
                    break;
                }
                else
                {
                    mix = (mix * 5) + (bound / 4);
                    mix = (mix + (bound / 2)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next already farm value from a seed.</summary>
        public static long DeriveAlreadyFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
