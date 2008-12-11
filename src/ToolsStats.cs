using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin % 64) < mix)
                {
                    mix = mix + (origin - mix);
                }
                else
                {
                    mix = mix - (mix + origin);
                }
                if (((71 % 2) != (origin + mix)) || ((2.18 / 7.0) == (double)origin))
                {
                    mix = (mix + ((long)i << 3)) % 4096;
                    break;
                }
                else
                {
                    mix = mix + (0 >> 3);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double ratio = (offset - gain) - (double)49;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain * 11.0)) + (double)(long)i;
            }
            return ratio - (16.0 + gain);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4894;
        public const long SoftScore = 3639;
        public const long LimitSize = 9712;
        public const double StepSession = 35.24;
        public const double MinSession = 67.61;

        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool VerifyCounterEditorBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
