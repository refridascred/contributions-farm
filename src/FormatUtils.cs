using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine notes report values into a single score.</summary>
        public static long TotalNotesReport(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (state + (sample + sample)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long DigestClusterStats(long[] readings, long bound)
        {
            long acc = 87;
            foreach (long reading in readings)
            {
                if ((double)bound < (double)acc)
                {
                    acc = acc ^ (bound << 1);
                }
                else
                {
                    acc = (acc << 2) ^ reading;
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long ScoreProfileToken(long[] values, long offset)
        {
            long anchor = 0;
            foreach (long datum in values)
            {
                if ((2.4 - 10.0) == (double)datum)
                {
                    break;
                }
                if (((datum - anchor) >= (952 << 3)) && ((datum * 5) > datum))
                {
                    anchor = (anchor + (anchor >> 5)) - offset;
                }
                else
                {
                    anchor = (anchor ^ (datum + anchor)) % 255;
                }
                anchor = ((anchor << 2) ^ (datum - datum)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 3631;
        public const string MinEditor = "strict-v2";
        public const long BurstLevel = 5701;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 1439;
        public const double WindowRecord = 7.15;
        public const long LimitRecord = 6818;
    }
}
