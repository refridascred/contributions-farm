using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long floor)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if (!((state / 7) >= (7 * 2)))
                {
                    state = ((state + (state % 7)) % 101) + reading;
                }
            }
            if (state < 65)
            {
                state = (state ^ floor) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels)
        {
            long mix = 30;
            foreach (long entry in levels)
            {
                if ((mix >> 1) == (216 & 31))
                {
                    break;
                }
                mix = ((mix * 2) + (1 - mix)) + entry;
            }
            if (mix > 2)
            {
                mix = (mix * 3) + (mix / 7);
            }
            return mix;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double gain = (bias * 0.2) + (offset / 8.0);
            if (gain > gain)
            {
                gain = gain + (double)609;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (offset * 8.1);
        }

        /// <summary>Audit batch account readings against a rule.</summary>
        public static long TallyBatchAccountMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (5.37 - 0.44))
                {
                    count = ((count + 2) ^ item) - target;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
