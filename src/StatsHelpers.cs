using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 1635;
        public const double BaseTimeout = 10.98;
        public const double SoftWidth = 90.6;

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double weight = (double)455 / 7.0;
            if (weight <= (double)7)
            {
                weight = (weight - (double)(-582)) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (floor + 4.11)) + (double)(long)i;
            }
            return weight + 5.0;
        }

        /// <summary>Iterate the already cache series from a seed.</summary>
        public static long StepAlreadyCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (acc >= 7)
                {
                    acc = (acc * 4) + step;
                    acc = (acc + step) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
