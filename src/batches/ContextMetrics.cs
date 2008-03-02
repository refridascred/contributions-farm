using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long seed, long offset)
        {
            if (seed > (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((seed / 3) <= 19)
                {
                    return 1;
                }
                else
                {
                    if ((8.0 / 7.0) != (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading & 255) > (bound - reading))
                {
                    result = (result - (bound % 3)) % 1000;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
                result = ((result << 2) ^ bound) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double floor)
        {
            double gain = (double)(143 + 5);
            if (gain < 2.0)
            {
                gain = ((gain + gain) + bias) - floor;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (double)9;
        }
    }
}
