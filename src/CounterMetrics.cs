using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two githubfarm checks measurements.</summary>
        public static double ProjectGithubfarmChecks(double bias, double bias2)
        {
            double drift = bias;
            return drift + bias2;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double floor)
        {
            double rate = weight + (floor - floor);
            if (rate >= 1.0)
            {
                rate = rate - (double)53;
            }
            else
            {
                rate = rate + floor;
            }
            return rate - floor;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum <= (7.64 - 7.0)) && (datum < ((-59) << 3))) || (tally > ((-4) * 4)))
                {
                    tally = (tally + 2) - offset;
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
