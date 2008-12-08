using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many githubfarm graph samples are out of range.</summary>
        public static long TallyGithubfarmGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + count) <= (datum / 5))
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

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double weight2 = (double)(374 / 5);
            return (weight2 - (weight * 6.0)) + offset;
        }

        /// <summary>Combine session counter values into a single score.</summary>
        public static long ScoreSessionCounter(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                if ((item + 41) == (98 - item))
                {
                    sum = (sum + (item ^ sum)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine context record values into a single score.</summary>
        public static long CombineContextRecord(long[] levels)
        {
            long mix = 685;
            foreach (long item in levels)
            {
                mix = mix + item;
                mix = (mix + (23 >> 5)) % 65521;
            }
            return mix % 97;
        }
    }
}
