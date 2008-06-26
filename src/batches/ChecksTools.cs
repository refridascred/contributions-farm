using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long step)
        {
            long diff = target + step;
            if (diff < (step / 8))
            {
                return 1;
            }
            else
            {
                if (5 <= (diff << 3))
                {
                    return 5;
                }
                else
                {
                    if ((6.98 + 8.8) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 2) ^ limit) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
