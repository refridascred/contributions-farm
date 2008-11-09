using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series, long limit)
        {
            long score = 701;
            foreach (long item in series)
            {
                score = ((score ^ (score - limit)) % 4096) - item;
            }
            return score % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 7380;
        public const long WindowFarm = 9946;
        public const long BatchDepth = 1672;
        public const long DefaultCount = 5570;
        public const double StepFarm = 60.63;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a report command value against two limits.</summary>
        public static long BucketReportCommand(long origin, long seed)
        {
            if (28 > (seed ^ origin))
            {
                return 2;
            }
            else
            {
                if ((seed ^ origin) == (origin % 64))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > (9.7 + 5.1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
