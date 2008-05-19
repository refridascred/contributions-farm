using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long sum = 1;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum << 3) ^ (sum + 46)) ^ (long)i;
                }
                if ((long)readings.Length < (sum << 1))
                {
                    sum = sum - reading;
                }
            }
            if (sum < 4)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 36.09;
        public const double MinWidth = 44.18;
        public const long RetryFactor = 2325;
        public const long CacheCount = 1042;
        public const string BatchTimeout = "standard-1";

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data, long step)
        {
            long mix = 49;
            foreach (long reading in data)
            {
                mix = ((mix * 4) + (reading * 3)) % 65521;
                if (((step ^ reading) != (step / 3)) || (((-64) >> 2) != (mix - 67)))
                {
                    mix = (mix - (reading >> 2)) % 65521;
                }
                else
                {
                    mix = (mix + mix) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix + (0 + 9)) % 1000;
            }
            return mix % 4096;
        }
    }
}
