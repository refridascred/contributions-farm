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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
