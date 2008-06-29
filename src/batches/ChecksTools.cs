using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long total = 2;
            foreach (long reading in values)
            {
                total = ((total * 2) + (floor - reading)) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next stats graph value from a seed.</summary>
        public static long StepStatsGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)seed >= (9.64 / 2.0)))
                {
                    score = (score + (long)i) % 101;
                    score = ((score * 5) + (seed - seed)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] data)
        {
            long total = 966;
            foreach (long sample in data)
            {
                if (!(320 <= (total - sample)))
                {
                    total = total - total;
                }
                if (((sample / 4) < sample) && ((sample + 63) <= (5 >> 1)))
                {
                    total = ((total * 3) + sample) % 65521;
                }
                else
                {
                    total = total ^ (total + total);
                }
            }
            return total;
        }

        /// <summary>Project the next token farm value.</summary>
        public static double BlendTokenFarm(double bias, double bias2)
        {
            double load = (bias - 15.0) - 6.72;
            if (load > (bias2 - load))
            {
                load = load + (load / 9.0);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias2) + (double)(long)i;
            }
            return load + (bias + bias);
        }
    }
}
