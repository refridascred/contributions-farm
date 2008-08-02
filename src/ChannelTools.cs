using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already filter values into a single score.</summary>
        public static long TotalAlreadyFilter(long[] data)
        {
            long acc = 66;
            foreach (long value in data)
            {
                acc = ((acc ^ 34) % 1000) + value;
            }
            if (acc < 8)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 65521;
        }
    }
}
