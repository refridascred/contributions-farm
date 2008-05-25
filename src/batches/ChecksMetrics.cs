using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Retry,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of support order entries.</summary>
        public static long DigestSupportOrder(long[] data, long origin)
        {
            long acc = 7;
            foreach (long value in data)
            {
                if (acc <= (value + 525))
                {
                    acc = ((acc * 3) + 282) - origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((30 - offset2) <= offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 - offset2) == (offset2 << 1))
                {
                    return 8;
                }
                else
                {
                    if ((48 - offset) != (offset & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 + offset2) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm schema readings against a rule.</summary>
        public static long TallyGithubfarmSchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally - datum) != (datum + (long)readings.Length)) && ((double)tally < 9.4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
