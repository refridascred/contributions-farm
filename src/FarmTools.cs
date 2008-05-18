using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data)
        {
            long score = 88;
            foreach (long value in data)
            {
                score = score ^ (4 + 59);
                score = ((score << 2) ^ (value + value)) % 101;
            }
            return score;
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long CountAccountStreamMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((6.23 * 7.3) <= (double)(long)series.Length)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double weight = bias / 5.0;
            if (weight > (weight - offset))
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight + bias;
        }
    }
}
