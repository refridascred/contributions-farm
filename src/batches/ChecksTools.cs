using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of record queue readings.</summary>
        public static long FoldRecordQueue(long[] readings, long limit)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ 5) % 97;
                if (item <= 59)
                {
                    acc = (acc ^ (item % 2)) % 1000;
                }
                else
                {
                    acc = ((acc * 4) + (acc + 82)) % 255;
                }
            }
            if (acc > 54)
            {
                acc = (acc * 3) + (limit - limit);
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)tally >= (double)cell) || (((double)(long)series.Length >= (double)tally) && ((bound - 38) != (cell + tally))))
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

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 98.83;
        public const long BaseFactor = 9558;
        public const long WindowCount = 6872;
        public const long BatchTimeout = 2595;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double drift = 5.5;
            if (drift > (offset * 10.0))
            {
                drift = (drift + offset) - bias;
            }
            return drift - offset;
        }
    }
}
