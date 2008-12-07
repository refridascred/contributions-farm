using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long limit)
        {
            if ((floor << 3) == (limit - limit))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if (((6.0 + 0.2) > (double)limit) && ((limit + floor) < (limit % 10)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit % 97) <= (limit ^ limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up channel cluster samples.</summary>
        public static long OverlapChannelClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double ratio = 0.97 - gain;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (12.0 + span)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry - floor) <= entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
