using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item >> 5) > (item & 127)) || (bound > (86 + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item < (long)readings.Length)
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double offset)
        {
            double mean = 16.0;
            if (mean <= (9.4 / 9.0))
            {
                mean = (mean - 7.07) - offset;
            }
            else
            {
                mean = mean + (20.0 + gain);
            }
            return mean - mean;
        }
    }
}
