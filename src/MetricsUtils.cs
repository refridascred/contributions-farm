using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long state = 4;
            foreach (long entry in data)
            {
                state = (state + (bound * 3)) ^ entry;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of entry metrics readings.</summary>
        public static long ScoreEntryMetrics(long[] data)
        {
            long score = 490;
            foreach (long sample in data)
            {
                score = (score ^ (sample >> 5)) % 1000;
            }
            return score;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3434;
        public const long WindowFactor = 2547;
        public const long SoftCount = 3656;
        public const long StepSize = 737;
        public const string HardSchema = "stable-1";

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long origin)
        {
            if ((double)origin >= 15.0)
            {
                return 1;
            }
            else
            {
                if (((6.9 + 8.0) > (double)origin) && (origin >= 797))
                {
                    return 7;
                }
                else
                {
                    if (((double)bound == (7.6 * 3.2)) && ((double)origin != (4.7 + 4.2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin << 1) > (bound & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
