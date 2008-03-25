using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit cache token readings against a rule.</summary>
        public static long TallyCacheTokenGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >= (9 - cell)) || ((floor <= (491 / 8)) && (cell < (290 + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + 0) >= (568 >> 4))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)score < (7.0 * 9.3)))
                {
                    score = ((score << 3) ^ score) % 101;
                }
                score = ((score << 2) ^ (long)i) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double mean = ratio + (ratio + 2.57);
            if (mean < (floor * 8.0))
            {
                mean = mean + (ratio / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (floor / 8.0)) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Project the next session counter value.</summary>
        public static double BlendSessionCounter(double ratio, double floor)
        {
            double drift = (double)(0 - 600);
            return (drift - ratio) + floor;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double weight = 2.6;
            if (weight > (10.0 / 6.0))
            {
                weight = ((weight + (double)5) - bias) - offset;
            }
            return weight - (double)731;
        }
    }
}
