using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first githubfarm stats entry that matches the target.</summary>
        public static long FindGithubfarmStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)5 < (double)origin)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double floor)
        {
            double gain = (8.11 - floor) + (double)(-9);
            if (gain >= 7.16)
            {
                gain = gain + (floor - floor);
            }
            else
            {
                gain = gain - scale;
            }
            return gain + (double)0;
        }
    }
}
