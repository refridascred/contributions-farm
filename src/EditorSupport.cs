using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a filter stats reading.</summary>
        public static double SmoothFilterStats(double bias, double floor)
        {
            double load = bias;
            if (load <= bias)
            {
                load = (load - bias) - floor;
            }
            return load - bias;
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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (((0 << 1) < (sum ^ (long)i)) && ((step * 4) < (4 >> 3)))
                {
                    sum = ((sum * 5) + (sum + 389)) % 1000;
                    sum = (sum - (step + step)) % 97;
                }
                else
                {
                    sum = (sum + ((long)i + step)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
