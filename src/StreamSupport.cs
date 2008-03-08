using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double weight = (gain * 4.5) * 1.35;
            return (weight - (double)208) + floor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (2.92 - 1.46))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc * 5) + (acc * 5)) % 255) ^ (long)i2;
                    acc = acc - (acc % 24);
                }
                if ((limit % 7) > acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc * 4) + (long)i) % 255;
                }
                if ((double)(long)i != (19.0 - 5.4))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    acc = ((acc * 4) + acc) % 97;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
