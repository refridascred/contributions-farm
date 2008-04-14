using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (step < (datum + count))
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

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Active,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Scale a format notes figure with a bias.</summary>
        public static double BlendFormatNotes(double weight, double bias)
        {
            double gain = (double)((-14) + 251);
            if (gain < gain)
            {
                gain = gain - (gain + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - (double)291;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a batch filter pair into a bucket.</summary>
        public static long BucketBatchFilter(long origin, long step)
        {
            if (((step & 31) >= (step / 6)) || ((step * 5) > (step + step)))
            {
                return 2;
            }
            else
            {
                if ((1.28 * 3.2) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((origin - 633) > (6 + origin)) && ((double)origin != (1.95 + 8.28)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
