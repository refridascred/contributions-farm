using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double ratio = (double)(99 + 92);
            if (ratio < 7.0)
            {
                ratio = ((ratio - (ratio + ratio)) + weight) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (6.0 / 4.0);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (803 > (datum * 3))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a window command counter forward.</summary>
        public static long RollWindowCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((acc << 2) > ((long)i - 67))
                {
                    acc = (acc ^ (seed - (long)i)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (seed >> 2)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
