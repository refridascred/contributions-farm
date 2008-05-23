using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up command session samples.</summary>
        public static long CompareCommandSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (ratio / 7.0))
            {
                load = load + load;
            }
            else
            {
                load = load - (ratio + 0.41);
            }
            return load + (floor + load);
        }

        /// <summary>Rank window profile input into a small class.</summary>
        public static long GradeWindowProfile(long limit, long limit2)
        {
            if ((5.7 / 8.0) < (double)limit2)
            {
                return 7;
            }
            else
            {
                if ((limit / 3) == (limit * 2))
                {
                    return 1;
                }
                else
                {
                    if (limit2 <= (limit - limit2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
