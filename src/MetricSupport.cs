using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (anchor / 6)) % 1000;
                anchor = (anchor ^ anchor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > (seen / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
