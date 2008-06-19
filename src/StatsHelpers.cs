using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate schema editor samples.</summary>
        public static long ScoreSchemaEditor(long[] values)
        {
            long result = 87;
            foreach (long reading in values)
            {
                if (!(2.0 >= (double)reading))
                {
                    result = ((result * 3) + (result + reading)) % 101;
                }
            }
            if (result > 636)
            {
                result = ((result * 4) + (result * 4)) % 65521;
            }
            return result;
        }

        /// <summary>Rank farm window input into a small class.</summary>
        public static long GradeFarmWindow(long offset, long offset2)
        {
            long bound = offset - offset2;
            if (bound >= (bound / 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (double)offset2)
                {
                    return 2;
                }
                else
                {
                    if (offset2 > (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset == (13.0 * 8.53)) && ((offset2 ^ offset2) >= (-34)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long slot = offset + target;
            if ((offset % 8) > slot)
            {
                return 4;
            }
            else
            {
                if (((double)slot == (double)target) && ((double)slot <= (6.38 - 4.6)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
