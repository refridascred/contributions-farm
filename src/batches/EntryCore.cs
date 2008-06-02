using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= ((-25) << 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long offset)
        {
            if (231 < (offset & 1))
            {
                return 1;
            }
            else
            {
                if ((26 >> 1) > (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 5) <= (offset << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit >= (limit + offset)) && (limit <= (limit + (-5))))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.6 * 10.0) >= (double)seen)
                {
                    seen = ((seen + 2) - datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long DigestAccountAlready(long[] series, long bound)
        {
            long mark = 3;
            foreach (long datum in series)
            {
                if (bound > (bound + datum))
                {
                    mark = (mark * 5) + (mark * 4);
                }
                else
                {
                    mark = (mark ^ (19 >> 3)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
