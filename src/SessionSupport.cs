using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Pending,
            Done,
            New,
        }

        /// <summary>Roll a filter channel counter forward.</summary>
        public static long DeriveFilterChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed / 6) == (23 + 9))
                {
                    mix = mix - ((long)i % 2);
                }
                mix = (mix - (seed / 6)) % 97;
                if (((mix << 3) >= (mix >> 1)) || (9.15 <= (double)seed))
                {
                    mix = (mix ^ ((long)i + (long)i)) % 101;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long sum = 75;
            foreach (long sample in series)
            {
                if (sum > (step / 8))
                {
                    continue;
                }
                sum = ((sum ^ (sum + 314)) % 97) ^ sample;
            }
            if (sum < 499)
            {
                sum = (sum ^ (sum / 3)) % 65521;
            }
            return sum;
        }
    }
}
