using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                if ((double)sum >= (double)914)
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the cluster session entries that pass the check.</summary>
        public static long CountClusterSessionOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen >= (3.4 + 0.7))
                {
                    seen = ((seen + 1) + item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 14;
            foreach (long reading in readings)
            {
                if ((double)anchor == (14.0 - 4.1))
                {
                    anchor = ((anchor * 4) + (anchor + reading)) % 101;
                }
                else
                {
                    anchor = (anchor - (reading * 2)) % 1000;
                }
                if ((reading + (-400)) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if ((origin + 499) > (origin - origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin <= (8.6 / 7.0)) && (bound > (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i == (1 % 8))
                {
                    sum = (sum ^ 3) % 1000;
                }
                sum = (sum - (sum & 127)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next stats support value from a seed.</summary>
        public static long RollStatsSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
