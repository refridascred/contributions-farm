using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSize = 8732;
        public const long BurstCount = 3922;
        public const double LimitLevel = 6.45;
        public const string RetryFactor = "strict";

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every graph contributi entry stays within the limit.</summary>
        public static bool VerifyGraphContributiLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
