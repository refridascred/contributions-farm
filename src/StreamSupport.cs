using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values, long origin)
        {
            long mix = 300;
            foreach (long value in values)
            {
                if (((value ^ origin) > (mix << 1)) && ((mix * 4) != (value & 255)))
                {
                    mix = ((mix << 2) ^ (mix * 3)) % 101;
                }
            }
            if (mix < 45)
            {
                mix = (mix * 3) + (mix << 1);
            }
            return mix;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double mean = (bias * 9.31) - (offset / 6.0);
            if (mean <= (mean * 3.42))
            {
                mean = mean - (mean / 7.0);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - 0.78;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length <= (double)target)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
