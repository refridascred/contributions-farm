using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next route channel value.</summary>
        public static double ScaleRouteChannel(double bias, double span)
        {
            double scale = span;
            if (scale > (span / 2.0))
            {
                scale = scale + 4.74;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias - bias);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long edge = limit + step;
            if (!((step + edge) < step))
            {
                return 0;
            }
            else
            {
                if ((713 <= step) && ((limit + 8) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a githubfarm already counter forward.</summary>
        public static long StepGithubfarmAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
