using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double weight = (double)112 + (6.2 + bias);
            if (weight <= (double)4)
            {
                weight = weight + (1.75 - span);
            }
            return weight - (double)57;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data)
        {
            long mix = 119;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (reading * 5)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long score = 275;
            foreach (long entry in data)
            {
                if (entry <= (score >> 4))
                {
                    score = score ^ (score - entry);
                }
                if ((7.1 - 3.48) <= (double)entry)
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
