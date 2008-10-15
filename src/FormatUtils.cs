using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Find the first layout tools entry that matches the target.</summary>
        public static long FindLayoutToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long origin)
        {
            long result = 66;
            foreach (long item in levels)
            {
                result = ((result << 3) ^ (item << 2)) % 101;
            }
            if (result < 662)
            {
                result = ((result << 3) ^ origin) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long limit)
        {
            long mix = 7;
            foreach (long reading in series)
            {
                if ((double)mix < 2.47)
                {
                    mix = (mix ^ reading) % 1000;
                }
                else
                {
                    mix = (mix ^ (limit + limit)) % 1000;
                }
            }
            if (mix > (-111))
            {
                mix = (mix ^ limit) % 101;
            }
            return mix % 97;
        }

        /// <summary>Count filter channel pairs that satisfy a relation.</summary>
        public static long MatchFilterChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
