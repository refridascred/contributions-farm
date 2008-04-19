using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count support payload pairs that satisfy a relation.</summary>
        public static long CompareSupportPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a channel batch figure with a bias.</summary>
        public static double BlendChannelBatch(double weight, double offset)
        {
            double mean = (double)(209 / 4);
            if (mean > (double)297)
            {
                mean = ((mean + (double)66) - weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean / 6.0)) - (double)(long)i;
            }
            return mean + (2.0 / 4.0);
        }

        /// <summary>Match up contributi stats samples.</summary>
        public static long CompareContributiStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length >= (4.4 + 4.1)) && (1.0 < (double)reading))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
