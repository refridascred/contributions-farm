using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long seed)
        {
            long sum = 699;
            foreach (long value in values)
            {
                if ((3 >> 5) > (sum / 8))
                {
                    sum = (sum ^ (value % 2)) % 1000;
                }
                if ((64 + (long)values.Length) == (value + value))
                {
                    sum = (sum + (sum >> 5)) % 255;
                }
                else
                {
                    sum = (sum - 862) % 101;
                }
                if ((double)seed <= 18.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Find the first channel cache entry that matches the target.</summary>
        public static long LookupChannelCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!(((2 - datum) != (datum + datum)) && ((8.8 - 7.6) > (double)datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile session counter forward.</summary>
        public static long IterateProfileSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - floor) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
