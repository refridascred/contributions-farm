using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a metrics checks counter forward.</summary>
        public static long SeriesMetricsChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((904 < acc) && (6.58 >= (double)limit))
                {
                    acc = (acc - ((long)i << 2)) % 1000;
                }
                acc = acc ^ ((long)i % 3);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
