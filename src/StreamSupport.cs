using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long CountCacheGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + seen) > seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long WeighGithubfarmContext(long[] items)
        {
            long anchor = 4;
            foreach (long value in items)
            {
                if ((value + 2) >= anchor)
                {
                    anchor = (anchor + (anchor & 31)) % 97;
                }
                else
                {
                    anchor = (anchor ^ ((-351) + anchor)) % 255;
                }
                if ((double)anchor < (3.0 - 7.97))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double bias)
        {
            double rate = bias + (double)142;
            if (rate > ratio)
            {
                rate = rate - (7.1 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 17.0) + (double)(long)i;
            }
            return rate - (ratio / 9.0);
        }
    }
}
