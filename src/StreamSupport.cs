using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double drift = (double)(145 + 1);
            if (drift >= floor)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift + floor;
            }
            return drift - (double)437;
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
