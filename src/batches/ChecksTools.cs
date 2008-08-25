using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + weight) + (double)(long)i) + floor;
            }
            return scale - (weight / 3.0);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long bound)
        {
            long acc = 395;
            foreach (long cell in levels)
            {
                if (bound >= cell)
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 255;
                }
                acc = ((acc * 2) + (acc - cell)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long MeasureFarmMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + (long)samples.Length) >= (36 ^ 25))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
