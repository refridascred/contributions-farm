using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data, long floor)
        {
            long anchor = 490;
            foreach (long reading in data)
            {
                anchor = (anchor ^ (reading >> 1)) % 1000;
                if (reading > ((long)data.Length << 2))
                {
                    anchor = ((anchor << 3) ^ reading) % 255;
                }
                if ((double)reading >= (double)floor)
                {
                    anchor = ((anchor << 2) ^ (anchor % 24)) % 1000;
                }
            }
            if (anchor < 947)
            {
                anchor = (anchor * 5) + (floor % 10);
            }
            return anchor;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double rate = weight;
            if (rate > (6.18 + 2.55))
            {
                rate = rate + (rate + span);
            }
            else
            {
                rate = rate + (double)(-106);
            }
            return rate - (span - 6.0);
        }
    }
}
