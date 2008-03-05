using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                long lane = (floor & 63) * 3;
                carry = ((carry << 3) ^ lane) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of session schema entries.</summary>
        public static long FoldSessionSchema(long[] levels, long seed)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = (((mark * 5) + (982 + seed)) % 1000) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long value in readings)
            {
                mix = (((mix * 5) + (mix >> 1)) + value) + seed;
                if ((long)readings.Length >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
