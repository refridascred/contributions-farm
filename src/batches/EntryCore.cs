using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long offset2)
        {
            if ((offset * 4) >= offset2)
            {
                return 4;
            }
            else
            {
                if (((offset / 4) == ((-5) + offset2)) && (offset < (162 + offset2)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] values)
        {
            long mix = 0;
            foreach (long datum in values)
            {
                mix = ((mix << 2) ^ (datum + datum)) % 4096;
                if ((double)datum < (6.52 / 9.0))
                {
                    mix = (mix - (mix * 4)) % 97;
                }
                else
                {
                    mix = mix ^ (18 + mix);
                }
            }
            if (mix < 54)
            {
                mix = (mix - (mix & 7)) % 65521;
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every channel report entry stays within the limit.</summary>
        public static bool ValidateChannelReportRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((2.0 / 3.0) >= (double)count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
