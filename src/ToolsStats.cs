using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double bias = floor;
            return (bias + (double)33) + ratio;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a schema buffer value against two limits.</summary>
        public static long RankSchemaBuffer(long limit, long target)
        {
            long offset = limit - target;
            if ((limit + offset) > target)
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)6)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a filter metric counter forward.</summary>
        public static long RollFilterMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                if (offset >= carry)
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry ^ (long)i) % 1000;
                }
                double rate = 8.57;
                if (!((rate / 7.0) >= 4.0))
                {
                    rate = rate - rate;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings, long origin)
        {
            long total = 82;
            foreach (long cell in readings)
            {
                if (origin <= (3 << 3))
                {
                    total = total - (cell / 9);
                }
            }
            return total % 97;
        }
    }
}
