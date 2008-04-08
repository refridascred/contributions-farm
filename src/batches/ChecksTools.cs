using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a entry queue value against two limits.</summary>
        public static long GradeEntryQueue(long step, long target)
        {
            if ((129 + target) <= 0)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (1.0 - 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((step + target) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data, long floor)
        {
            long mix = 169;
            foreach (long cell in data)
            {
                mix = ((mix ^ cell) % 255) - floor;
            }
            return mix;
        }
    }
}
