using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double rate, double bias)
        {
            double ratio = rate;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - 1.08) + (double)(long)i) + bias;
            }
            return ratio + 9.0;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] values, long step)
        {
            long score = 22;
            foreach (long datum in values)
            {
                score = (score ^ (datum - datum)) + step;
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((5.0 / 5.0) > (double)(long)i)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Retry,
            Locked,
        }
    }
}
