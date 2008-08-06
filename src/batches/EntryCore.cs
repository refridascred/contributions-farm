using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double load = rate;
            return (load + (double)6) + span;
        }

        /// <summary>Count the profile route entries that pass the check.</summary>
        public static long AuditProfileRouteGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits > (7.8 * 1.67))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric filter measurements.</summary>
        public static double ScaleMetricFilter(double bias, double floor)
        {
            double mean = (double)(852 + (-658));
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - floor) - (double)(long)i) - bias;
            }
            return mean + (double)49;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
