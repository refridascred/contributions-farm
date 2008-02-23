using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long limit)
        {
            if ((origin << 1) <= origin)
            {
                return 7;
            }
            else
            {
                if ((2 % 64) <= (limit >> 4))
                {
                    return 4;
                }
                else
                {
                    if (!((11.0 - 20.0) >= (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.5 * 0.4) <= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (bound * 3))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel filter values into a single score.</summary>
        public static long CombineChannelFilter(long[] values)
        {
            long anchor = 9;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ 520) % 4096) + sample;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of format cluster entries.</summary>
        public static long DigestFormatCluster(long[] readings)
        {
            long acc = 4;
            foreach (long value in readings)
            {
                if (70 < acc)
                {
                    acc = ((acc - (acc ^ acc)) % 255) + value;
                }
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((254 + seen) < seen) && ((78 & 63) >= seen))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
