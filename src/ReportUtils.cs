using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] levels, long offset)
        {
            long score = 14;
            foreach (long entry in levels)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score - (long)i2) % 1000) ^ entry;
                    score = (score + (score << 1)) % 255;
                }
                score = score + (score >> 3);
            }
            if (score > 720)
            {
                score = ((score * 4) + (offset << 3)) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ bound) % 1000) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long DigestBufferCache(long[] readings)
        {
            long mark = 932;
            foreach (long entry in readings)
            {
                mark = (((mark * 4) + ((-9) + 47)) % 97) ^ entry;
            }
            return mark;
        }

        /// <summary>Compare every pair of graph payload readings.</summary>
        public static long MatchGraphPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long seed)
        {
            if ((origin % 2) < (seed - seed))
            {
                return 7;
            }
            else
            {
                if (!((seed - origin) <= (seed >> 5)))
                {
                    return 8;
                }
                else
                {
                    if (!((seed << 2) > (origin ^ seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
