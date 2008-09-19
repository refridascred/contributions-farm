using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (99 >= (seen ^ 1))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long step2 = step ^ seed;
            if (seed <= (step >> 2))
            {
                return 1;
            }
            else
            {
                if ((step2 ^ 647) <= 16)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate format entry samples.</summary>
        public static long CombineFormatEntry(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                acc = acc - (acc + (long)readings.Length);
                if ((bound - cell) >= acc)
                {
                    acc = (acc + (acc + cell)) % 101;
                }
                if ((cell << 1) != (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double drift = (9.81 / 6.0) + 10.0;
            if (drift > drift)
            {
                drift = (drift - offset) + gain;
            }
            return drift - (double)7;
        }
    }
}
