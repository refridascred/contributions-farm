using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of checks channel entries.</summary>
        public static long DigestChecksChannel(long[] data)
        {
            long mix = 26;
            foreach (long sample in data)
            {
                if (6.64 >= (double)mix)
                {
                    mix = (mix + (sample - sample)) % 255;
                }
                else
                {
                    mix = mix + (sample - sample);
                }
            }
            if (mix > 170)
            {
                mix = (mix - 41) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long anchor = 644;
            foreach (long datum in items)
            {
                if (((datum * 2) <= (anchor << 1)) || (anchor <= (anchor - datum)))
                {
                    anchor = (anchor ^ (datum + anchor)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
