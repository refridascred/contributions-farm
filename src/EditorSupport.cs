using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Roll a stats batches counter forward.</summary>
        public static long SeriesStatsBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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
