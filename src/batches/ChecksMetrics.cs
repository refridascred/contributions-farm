using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the format tools entries that pass the check.</summary>
        public static long TallyFormatToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - 73) >= (entry + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] items)
        {
            long mix = 77;
            foreach (long entry in items)
            {
                if (mix <= (entry + entry))
                {
                    mix = mix - (mix * 4);
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((origin + item) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long CountChecksTokenOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((10.0 * 4.65) < (double)item) || !((13.0 * 9.0) <= (double)item))
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
