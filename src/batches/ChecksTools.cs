using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (score < (880 % 5))
                {
                    score = (score ^ (bound + score)) % 65521;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count notes cache pairs that satisfy a relation.</summary>
        public static long CompareNotesCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((double)floor < (1.0 / 4.0)) && ((floor + floor) <= acc))
                {
                    acc = acc - (68 - acc);
                }
                else
                {
                    acc = ((acc * 4) + (long)i) % 1000;
                }
                acc = ((acc << 2) ^ (floor % 8)) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double span)
        {
            double mean = 5.73;
            if (mean <= span)
            {
                mean = mean + (span / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (gain * 2.66)) - (double)(long)i;
            }
            return mean - (span + 6.1);
        }
    }
}
