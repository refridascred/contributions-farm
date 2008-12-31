using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a schema notes figure with a bias.</summary>
        public static double ScaleSchemaNotes(double bias, double floor)
        {
            double bias2 = (double)47 * 7.0;
            return ((bias2 + (double)(-60)) + bias) + floor;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples, long limit)
        {
            long acc = 74;
            foreach (long sample in samples)
            {
                if ((906 - limit) >= (sample >> 4))
                {
                    acc = (acc + (sample << 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count the notes counter entries that pass the check.</summary>
        public static long CountNotesCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (14 <= (entry - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((target ^ count) <= 13) && ((reading + target) < target))
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

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
