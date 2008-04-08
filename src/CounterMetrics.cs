using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double scale = ratio;
            if (scale < 15.0)
            {
                scale = (scale + (ratio * 18.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 4.8) + (double)(long)i;
            }
            return scale - (double)(-7);
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long mark = 240;
            foreach (long entry in readings)
            {
                if ((double)entry > (double)mark)
                {
                    mark = (mark + (396 % 2)) % 4096;
                }
                else
                {
                    mark = mark + (mark - mark);
                }
                if ((4 + entry) > (entry >> 3))
                {
                    break;
                }
            }
            if (mark < (-8))
            {
                mark = (mark ^ (mark >> 1)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Done,
            Draft,
        }
    }
}
