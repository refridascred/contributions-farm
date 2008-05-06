using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the context command series from a seed.</summary>
        public static long IterateContextCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                long count = floor ^ (38 + floor);
                score = (score << 3) ^ (count ^ score);
                score = (score - ((long)i % 16)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a batches record reading.</summary>
        public static double ScaleBatchesRecord(double gain, double offset)
        {
            double rate = gain;
            if (rate <= (double)524)
            {
                rate = rate - (12.0 / 9.0);
            }
            else
            {
                rate = rate + rate;
            }
            return rate - offset;
        }

        /// <summary>Check that every report githubfarm entry stays within the limit.</summary>
        public static bool VerifyReportGithubfarmRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
