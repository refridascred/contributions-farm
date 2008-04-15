using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine commits queue values into a single score.</summary>
        public static long TallyCommitsQueue(long[] levels, long step)
        {
            long score = 606;
            foreach (long datum in levels)
            {
                if ((step + step) < (step + datum))
                {
                    score = score - (93 + (long)levels.Length);
                }
                score = score + (score / 4);
                if ((5 & 127) > datum)
                {
                    score = score ^ (step + score);
                }
            }
            if (score < 822)
            {
                score = (score * 2) + (step + 2);
            }
            return score % 97;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double bias)
        {
            double scale = (3.03 * 6.6) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (ratio / 3.0);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
