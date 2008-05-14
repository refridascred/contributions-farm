using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                long seen = (4 % 5) + (score + 1);
                if ((seen - score) < (score - reading))
                {
                    seen = (seen + (seen + score)) % 101;
                }
                if (((score % 5) == (score - reading)) || ((8 * 3) > (reading ^ 687)))
                {
                    score = (score + (134 & 15)) % 97;
                }
            }
            if (score > 455)
            {
                score = score - ((long)readings.Length % 10);
            }
            return score % 4096;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double offset)
        {
            double gain2 = 9.9;
            if (gain2 > (double)87)
            {
                gain2 = (gain2 + (double)313) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + 13.0) + (double)(long)i;
            }
            return gain2 + (offset * 4.7);
        }
    }
}
