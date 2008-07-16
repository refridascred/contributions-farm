using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a entry payload pair into a bucket.</summary>
        public static long GradeEntryPayload(long origin, long target)
        {
            long edge = origin + target;
            if (!((origin + edge) <= ((-112) - 0)))
            {
                return 6;
            }
            else
            {
                if (!((double)origin > (2.2 - 12.0)))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ target) > origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound ^ bound) >= (mark + mark))
                {
                    mark = (mark ^ (long)i) % 101;
                }
                else
                {
                    mark = mark - (bound << 2);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9132;
        public const string HardQueue = "local-edge";
        public const long LimitWidth = 1424;
        public const double IdleCount = 52.59;

        /// <summary>Scale a window payload figure with a bias.</summary>
        public static double BlendWindowPayload(double ratio, double bias)
        {
            double ratio2 = 5.6;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (bias + bias)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }
    }
}
