using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of account stats readings.</summary>
        public static long TotalAccountStats(long[] data, long limit)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if ((limit >> 3) == (mark + datum))
                {
                    mark = ((mark * 2) + (datum << 2)) % 1000;
                }
                else
                {
                    mark = mark ^ (mark << 2);
                }
            }
            if (mark < 4)
            {
                mark = (mark * 4) + (20 >> 3);
            }
            return mark;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long carry = 36;
            foreach (long value in readings)
            {
                if (((value / 5) != (2 + carry)) && (value >= (value & 255)))
                {
                    break;
                }
                if ((offset - offset) < ((long)readings.Length + carry))
                {
                    carry = carry ^ 971;
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double floor)
        {
            double drift = (double)(584 & 31);
            if (drift < (drift * 4.9))
            {
                drift = ((drift - (drift / 4.0)) - bias) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)(-7);
        }
    }
}
