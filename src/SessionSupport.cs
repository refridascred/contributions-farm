using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a channel stream counter forward.</summary>
        public static long SeriesChannelStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)mark >= (8.4 + 3.23)))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool VerifyBatchContributiBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
