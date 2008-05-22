using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long TallyContributiRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((8.1 - 4.7) >= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool GuardAlreadyStreamLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
