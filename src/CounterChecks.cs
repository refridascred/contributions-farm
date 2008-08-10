using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches channel pair into a bucket.</summary>
        public static long BucketBatchesChannel(long limit, long step)
        {
            if ((871 < (step ^ 2)) || ((limit & 63) <= (limit ^ 59)))
            {
                return 3;
            }
            else
            {
                if (((30 ^ step) != (step >> 5)) || ((step / 4) == (step << 3)))
                {
                    return 1;
                }
                else
                {
                    if (limit > (step & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] values)
        {
            long result = -92;
            foreach (long value in values)
            {
                result = (result - ((-4) / 5)) % 4096;
                result = (result * 2) + (value ^ result);
            }
            return result;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter already readings against a rule.</summary>
        public static long CountCounterAlreadyGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((origin - origin) == (tally ^ origin)))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                if (((285 & 15) == (seed << 2)) && ((sample + anchor) >= (anchor ^ seed)))
                {
                    anchor = (anchor - (anchor - anchor)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
