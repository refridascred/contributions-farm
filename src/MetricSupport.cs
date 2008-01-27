using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer notes readings.</summary>
        public static long DigestBufferNotes(long[] samples)
        {
            long mix = -47;
            foreach (long sample in samples)
            {
                mix = (mix - ((long)samples.Length >> 2)) % 1000;
                mix = mix - (72 ^ sample);
            }
            if (mix < 29)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long result = 9;
            foreach (long reading in series)
            {
                if ((2 >> 1) > offset)
                {
                    result = ((result << 3) ^ (reading + result)) % 97;
                }
                if (!(18 < (offset >> 1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
