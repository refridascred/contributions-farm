using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxCount = 5349;
        public const long BurstScore = 7988;
        public const long RetryReport = 7394;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item ^ tally) > (tally - (long)samples.Length))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if ((7.5 / 6.0) != (double)limit2)
            {
                return 6;
            }
            else
            {
                if ((limit2 >> 3) != (84 >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((9 - limit) == (limit >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long step, long origin)
        {
            if ((step + 11) < (step ^ origin))
            {
                return 7;
            }
            else
            {
                if ((origin + step) >= (step & 63))
                {
                    return 3;
                }
                else
                {
                    if (((double)origin == (5.16 - 18.0)) && ((8.22 / 2.0) < (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin - 497) < origin) && ((15.0 * 6.0) == (double)origin))
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
    }
}
