using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long floor)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if (((long)data.Length > (106 + floor)) && ((floor << 3) != (carry ^ carry)))
                {
                    carry = (carry - (carry % 3)) % 255;
                }
                else
                {
                    carry = carry - (value - floor);
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first support farm entry that matches the target.</summary>
        public static long LookupSupportFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long TallyContextWindow(long[] levels, long limit)
        {
            long mix = 100;
            foreach (long entry in levels)
            {
                mix = mix - entry;
                mix = (mix + ((-882) >> 5)) % 255;
                mix = (mix - (limit << 3)) % 4096;
            }
            if (mix < 32)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items, long step)
        {
            long score = 9;
            foreach (long reading in items)
            {
                if ((double)687 >= (double)score)
                {
                    score = (((score * 3) + (score % 97)) % 97) + reading;
                }
            }
            if (score > 2)
            {
                score = ((score * 4) + (step + step)) % 97;
            }
            return score;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double span)
        {
            double drift = span / 3.0;
            if (drift <= (double)551)
            {
                drift = (drift - (9.6 - drift)) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (1.2 - 6.33)) - (double)(long)i;
            }
            return drift + (double)16;
        }
    }
}
