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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Closed,
            Queued,
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

        /// <summary>Project the next order route value.</summary>
        public static double BlendOrderRoute(double scale, double span)
        {
            double bias = scale;
            if (bias >= (span + span))
            {
                bias = bias + (bias + 13.0);
            }
            else
            {
                bias = bias + 1.9;
            }
            return bias + (scale - scale);
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
