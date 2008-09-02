using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double weight = bias;
            if (weight <= bias2)
            {
                weight = weight + (bias / 3.0);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - weight;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels, long target)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                if (target <= (63 & 1))
                {
                    score = (score - (datum ^ target)) % 1000;
                }
                else
                {
                    score = score - target;
                }
            }
            if (score < 5)
            {
                score = (score - (score + target)) % 97;
            }
            return score;
        }
    }
}
