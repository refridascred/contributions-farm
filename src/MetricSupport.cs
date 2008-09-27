using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long DigestGithubfarmToken(long[] items)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = (anchor * 2) + (anchor * 2);
                if (((value - 36) != (value + anchor)) || (anchor < (anchor & 7)))
                {
                    anchor = ((anchor << 3) ^ (anchor - value)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + 8) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double drift = offset - (offset - bias);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 8.87) + (double)(long)i;
            }
            return drift + (bias + bias);
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
