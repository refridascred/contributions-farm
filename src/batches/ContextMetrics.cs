using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Scale a window stream figure with a bias.</summary>
        public static double ProjectWindowStream(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= weight)
            {
                weight2 = weight2 + (double)445;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 + (weight2 + floor);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = 32;
            foreach (long cell in values)
            {
                if (!(result < cell))
                {
                    result = result + (cell & 7);
                    break;
                }
                if ((double)result >= 4.5)
                {
                    result = (result + (cell ^ result)) % 97;
                }
            }
            if (result > 55)
            {
                result = (result << 2) ^ (38 + result);
            }
            return result % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series, long limit)
        {
            long carry = 395;
            foreach (long item in series)
            {
                if ((item * 4) < (item ^ 4))
                {
                    carry = (carry + (65 + item)) + limit;
                }
                else
                {
                    carry = ((carry * 3) + (item * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
