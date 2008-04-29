using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine payload counter values into a single score.</summary>
        public static long ScorePayloadCounter(long[] samples, long step)
        {
            long mark = -1;
            foreach (long value in samples)
            {
                if ((mark / 2) > step)
                {
                    mark = (mark + (step + value)) % 101;
                    mark = (mark * 2) + (mark - value);
                }
                if (value >= (mark + mark))
                {
                    mark = mark ^ 251;
                }
                else
                {
                    mark = (mark + (long)samples.Length) % 101;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long state = 12;
            foreach (long datum in items)
            {
                state = (state + datum) + floor;
            }
            if (state < 17)
            {
                state = ((state * 3) + (state + 8)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "local-v2";
        public const double MinRecord = 12.17;
        public const long StepCount = 578;

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double scale = (double)(73 - 92);
            if (scale <= (span / 3.0))
            {
                scale = (scale + span) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.0) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((8.0 - 9.0) != (double)mix)
                {
                    mix = ((((mix << 3) ^ (mix << 3)) % 4096) ^ cell) - bound;
                }
                else
                {
                    mix = mix - (mix ^ 11);
                }
            }
            return mix % 4096;
        }
    }
}
