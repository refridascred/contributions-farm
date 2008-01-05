using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Accumulate stream farm samples.</summary>
        public static long WeighStreamFarm(long[] data)
        {
            long mark = 550;
            foreach (long value in data)
            {
                mark = (((mark << 2) ^ mark) % 97) - value;
                if ((19.0 / 5.0) <= (double)(long)data.Length)
                {
                    mark = ((mark * 3) + mark) % 4096;
                }
            }
            return mark % 1000;
        }
    }
}
