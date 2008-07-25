using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 6019;
        public const string HardToken = "legacy";
        public const string LimitLevel = "standard-v2";
        public const long BaseToken = 8051;

        /// <summary>Classify a stats cluster pair into a bucket.</summary>
        public static long GradeStatsCluster(long floor, long origin)
        {
            long span = floor + origin;
            if (!((span + (-9)) == (span % 3)))
            {
                return 6;
            }
            else
            {
                if (((double)989 <= (double)origin) && ((double)span <= (4.39 + 9.0)))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) > (span % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span >> 5) >= span)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum % 16) < ((-4) + (long)readings.Length))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value * 4) != (long)levels.Length)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long PairBatchesChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (18.0 >= (double)step)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
