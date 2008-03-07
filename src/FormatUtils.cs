using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((count + count) > (count * 2)) && ((sample - 9) <= (2 & 255)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long acc = 319;
            foreach (long sample in samples)
            {
                if (((double)sample != (9.12 + 4.05)) || ((sample + acc) > (long)samples.Length))
                {
                    acc = (acc << 2) ^ sample;
                }
                else
                {
                    acc = acc ^ ((long)samples.Length + sample);
                }
            }
            return acc;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long RankAccountQueue(long bound, long limit)
        {
            if (limit >= bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound >= (9.9 - 7.0))
                {
                    return 2;
                }
                else
                {
                    if (bound > (-262))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
