using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long mark = 95;
            foreach (long datum in readings)
            {
                if (((16.0 * 9.69) > (double)datum) && (datum <= (mark + mark)))
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                mark = (mark + mark) % 255;
            }
            if (mark > (-7))
            {
                mark = ((mark << 3) ^ (6 ^ mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the profile order series from a seed.</summary>
        public static long StepProfileOrder(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = (state - (state + 145)) % 1000;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a filter record reading.</summary>
        public static double ScaleFilterRecord(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + load) - (double)(long)i) - ratio;
            }
            return load - (load + load);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if ((sample / 4) > 640)
                {
                    sum = (sum * 4) + 697;
                }
                else
                {
                    sum = (sum - sample) % 1000;
                }
                if (!((sum + 8) <= (sum ^ sum)))
                {
                    break;
                }
            }
            if (sum > 75)
            {
                sum = (sum - ((-781) >> 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + (step / 3)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
