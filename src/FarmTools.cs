using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context queue value.</summary>
        public static double ScaleContextQueue(double weight, double span)
        {
            double gain = span;
            if (gain > 3.0)
            {
                gain = gain - (5.0 - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)82) - (double)(long)i;
            }
            return gain - (span + gain);
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Ready,
            New,
            Queued,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 2;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark * 4) + (long)i;
                    mark = mark ^ mark;
                }
                mark = mark ^ (cell % 3);
                if ((mark >> 3) <= (88 + cell))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark % 4096;
        }
    }
}
