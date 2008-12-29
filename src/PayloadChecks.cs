using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double load = offset / 4.0;
            if (load >= weight)
            {
                load = load - (4.4 / 2.0);
            }
            else
            {
                load = load - (load / 9.0);
            }
            return load - (double)51;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if (((979 & 15) >= (total * 2)) && ((total + (long)i) > (total >> 3)))
                {
                    total = (total * 4) + (step + 42);
                    total = ((total << 2) ^ (step / 7)) % 101;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long TallyLayoutCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(((double)count > (0.1 + 5.5)) && ((19.0 - 17.0) <= (double)cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up account buffer samples.</summary>
        public static long CompareAccountBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
