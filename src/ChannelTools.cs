using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long floor)
        {
            long mark = 39;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (floor - mark);
                if ((double)(long)readings.Length > (0.88 * 2.97))
                {
                    mark = ((mark << 2) ^ (cell % 16)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes stats values into a single score.</summary>
        public static long DigestNotesStats(long[] samples, long limit)
        {
            long sum = 35;
            foreach (long entry in samples)
            {
                sum = (sum - entry) % 101;
            }
            if (sum < 21)
            {
                sum = sum - (limit >> 2);
            }
            return sum;
        }
    }
}
