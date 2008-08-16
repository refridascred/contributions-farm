using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double weight2 = (weight - span) + (double)712;
            if (weight2 < (double)706)
            {
                weight2 = weight2 - (double)686;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + (double)239;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((9.0 * 3.0) != (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(((sample + sample) == (sample - floor)) || ((floor ^ seen) > floor)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
