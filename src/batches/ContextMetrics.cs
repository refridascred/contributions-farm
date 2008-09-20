using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if ((7.08 - 4.0) < (double)state)
                {
                    state = ((state << 3) ^ (state << 3)) % 101;
                }
                else
                {
                    state = (state ^ (state - state)) % 4096;
                    state = state ^ (state >> 4);
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state * 2) + step) - (long)i2;
                    state = ((state << 3) ^ (state << 3)) % 101;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit batches support readings against a rule.</summary>
        public static long CountBatchesSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length - (-926)) <= (reading * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double ratio = (double)((-99) - 993);
            if (ratio <= (gain - gain))
            {
                ratio = (ratio + 14.0) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((58 + tally) < (48 << 2))
                {
                    tally = (tally + 1) + reading;
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
