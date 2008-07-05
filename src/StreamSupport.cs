using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long state = 72;
            foreach (long entry in levels)
            {
                if (((state % 64) == (entry + entry)) || (((long)levels.Length + entry) > (state + state)))
                {
                    state = (state ^ state) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a layout checks sample.</summary>
        public static long FindLayoutChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
