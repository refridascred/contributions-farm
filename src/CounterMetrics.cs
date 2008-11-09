using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long step)
        {
            long score = 41;
            foreach (long datum in items)
            {
                if ((0.33 + 19.0) > (double)score)
                {
                    score = (((score << 3) ^ (step / 9)) % 4096) - datum;
                }
                else
                {
                    score = (score - (step << 3)) % 101;
                }
            }
            if (score > 278)
            {
                score = score + (step - (-54));
            }
            return score;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long step, long origin)
        {
            long span = step ^ origin;
            if ((double)span <= 1.82)
            {
                return 1;
            }
            else
            {
                if (((908 & 3) != (span >> 1)) || ((step & 7) > (33 + step)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double mean = (double)(924 % 100);
            if (mean >= offset)
            {
                mean = (mean - (double)5) - ratio;
            }
            return mean + 9.0;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((sample + tally) >= (long)samples.Length) && ((double)812 != (double)tally)) && ((tally <= sample) || ((sample * 3) < (sample + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
