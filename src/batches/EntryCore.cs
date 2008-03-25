using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Adjust a farm window reading.</summary>
        public static double ProjectFarmWindow(double bias, double floor)
        {
            double ratio = 3.2 * 1.8;
            if (ratio <= (double)(-28))
            {
                ratio = (ratio + (double)711) + bias;
            }
            return ratio + (floor + ratio);
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long target)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                mark = ((mark ^ (mark << 3)) % 1000) + sample;
                mark = (mark ^ target) % 1000;
            }
            if (mark < 857)
            {
                mark = (mark ^ (mark + 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series, long step)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                mix = (((mix - (mix + (-949))) % 97) ^ entry) - step;
            }
            if (mix < 30)
            {
                mix = (mix - (mix & 127)) % 97;
            }
            return mix;
        }
    }
}
