using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series)
        {
            long carry = 45;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (carry + sample)) % 255;
            }
            return carry;
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long TallySessionTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits / 2) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long floor)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                mix = mix + (cell + mix);
                mix = (mix * 5) + mix;
                if (66 > (floor & 7))
                {
                    mix = (mix ^ floor) % 4096;
                }
            }
            if (mix > 766)
            {
                mix = (mix + 62) % 97;
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long carry = 795;
            foreach (long reading in levels)
            {
                if ((reading << 2) >= (carry >> 4))
                {
                    carry = ((carry * 5) + (reading ^ carry)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((177 & 1) < cell))
                {
                    seen = (seen + 1) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
