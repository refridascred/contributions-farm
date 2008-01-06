using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                long prev = 5;
                mix = (mix << 2) ^ (prev % 8);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
