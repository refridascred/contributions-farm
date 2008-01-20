using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a notes window value against two limits.</summary>
        public static long ClassifyNotesWindow(long bound, long seed)
        {
            if ((bound - bound) >= (bound >> 5))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) >= (bound % 5))
                {
                    return 7;
                }
                else
                {
                    if (!(1 > (seed % 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (4.61 * 4.7)) + (double)(long)i) - weight;
            }
            return drift + (drift + bias);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally ^ item) > item) && (((tally * 4) <= item) && ((618 << 3) < ((long)samples.Length + item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
