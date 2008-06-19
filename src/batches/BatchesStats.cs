using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long seed, long bound)
        {
            if (!((bound >> 2) > (bound + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed % 7) > (seed + bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double load = offset;
            if (load < gain)
            {
                load = load + (double)974;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool GuardFilterContributiRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
