using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 706;
            foreach (long entry in items)
            {
                if (!((entry ^ sum) <= (4 - entry)))
                {
                    sum = ((sum * 2) + (sum % 16)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum >> 1);
                }
            }
            return sum;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double drift = 8.67;
            if (drift >= (double)876)
            {
                drift = (drift - (double)47) + gain;
            }
            else
            {
                drift = drift + (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - 1.23;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long floor)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((((anchor * 3) + 55) % 4096) - (long)i) - floor;
                }
                if ((sample >> 3) != ((-254) * 3))
                {
                    anchor = (anchor ^ 22) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate notes profile samples.</summary>
        public static long DigestNotesProfile(long[] data)
        {
            long mix = 780;
            foreach (long sample in data)
            {
                if (!((double)(-22) == (double)mix))
                {
                    mix = (mix ^ (sample << 2)) % 101;
                }
                if (!((0 + mix) < (sample - sample)))
                {
                    mix = ((mix << 3) ^ (10 % 60)) % 4096;
                }
                else
                {
                    mix = mix + (4 << 1);
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix;
        }
    }
}
