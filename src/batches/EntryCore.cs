using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long origin)
        {
            long cur = step + origin;
            if (!((6 >> 5) < (cur + origin)))
            {
                return 1;
            }
            else
            {
                if ((step - 463) <= (step * 3))
                {
                    return 0;
                }
                else
                {
                    if (!((441 + origin) >= cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)tally < 15.0))
                {
                    tally = ((tally + 3) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                if ((double)mix < (1.0 + 7.6))
                {
                    mix = ((mix << 2) ^ (reading ^ 988)) % 97;
                }
            }
            if (mix < 33)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Count order support pairs that satisfy a relation.</summary>
        public static long CompareOrderSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks schema reading.</summary>
        public static double BlendChecksSchema(double rate, double span)
        {
            double mean = rate;
            if (mean >= rate)
            {
                mean = mean - (rate * 9.0);
            }
            else
            {
                mean = mean - (mean + span);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)54) - (double)(long)i;
            }
            return mean + rate;
        }
    }
}
