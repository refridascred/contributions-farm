using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double span)
        {
            double load = weight;
            if (load > span)
            {
                load = load - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load - (load * 1.0);
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double scale, double floor)
        {
            double rate = 6.64 + (double)976;
            if (rate < floor)
            {
                rate = (rate - floor) - scale;
            }
            return rate + (double)(-1);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((long)data.Length - matches) <= (matches >> 4))
                {
                    matches = ((matches + 2) ^ item) + offset;
                }
            }
            return matches;
        }
    }
}
