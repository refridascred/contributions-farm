using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long seed)
        {
            long state = 42;
            foreach (long reading in samples)
            {
                state = ((state * 3) + (reading << 2)) % 4096;
            }
            if (state < (-938))
            {
                state = ((state * 5) + (seed >> 3)) % 65521;
            }
            return state;
        }

        /// <summary>Find the first metrics already entry that matches the target.</summary>
        public static long LocateMetricsAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout command readings.</summary>
        public static long CompareLayoutCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits == (8.35 - 5.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double weight = rate;
            if (weight >= (double)361)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - (double)679;
        }
    }
}
