using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio * 2.9))
            {
                ratio2 = ratio2 - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (offset - ratio2)) + (double)(long)i;
            }
            return ratio2 + (ratio2 * 6.8);
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long mix = 35;
            foreach (long item in levels)
            {
                if (((double)item >= (1.3 - 6.0)) || ((item - mix) <= (item + mix)))
                {
                    mix = (mix << 3) ^ bound;
                }
                else
                {
                    mix = (mix - (6 >> 1)) % 97;
                }
            }
            if (mix < 1)
            {
                mix = ((mix * 4) + (bound ^ 33)) % 97;
            }
            return mix;
        }
    }
}
