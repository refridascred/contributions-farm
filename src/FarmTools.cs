using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long limit)
        {
            if ((double)limit < (3.85 * 5.0))
            {
                return 1;
            }
            else
            {
                if ((limit % 97) > (limit / 5))
                {
                    return 5;
                }
                else
                {
                    if (272 < (floor + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (5 % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
