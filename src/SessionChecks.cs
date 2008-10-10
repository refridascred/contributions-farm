using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels, long floor)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                score = (score - (floor >> 5)) % 1000;
                if ((score < (floor ^ entry)) && ((score >> 2) == (floor + (-59))))
                {
                    score = score - (entry / 8);
                }
                else
                {
                    score = ((score * 2) + (score + floor)) % 255;
                }
            }
            return score;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double offset)
        {
            double bias = gain;
            if (bias > (gain + bias))
            {
                bias = bias - (9.29 * 5.84);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (offset * 4.63);
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values)
        {
            long score = 437;
            foreach (long sample in values)
            {
                score = ((score << 3) ^ score) % 65521;
                if ((sample >> 1) >= sample)
                {
                    score = score + (sample << 1);
                }
            }
            if (score < 55)
            {
                score = ((score << 3) ^ (score + 1)) % 65521;
            }
            return score % 97;
        }
    }
}
