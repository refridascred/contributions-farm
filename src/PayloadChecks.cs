using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the queue cache entries that pass the check.</summary>
        public static long MeasureQueueCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((1 - sample) == (count + sample)) && ((sample - count) != (count % 3))) && ((count - count) == (count / 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long bound)
        {
            long carry = -83;
            foreach (long entry in samples)
            {
                if ((bound <= (carry * 2)) && ((0 >> 5) >= (carry - bound)))
                {
                    break;
                }
                carry = ((carry ^ (2 + 71)) % 101) + entry;
                if ((0 % 60) > ((long)samples.Length & 127))
                {
                    carry = ((carry << 3) ^ (bound * 5)) % 65521;
                }
            }
            if (carry < 592)
            {
                carry = (carry - ((-721) - 866)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a metric payload sample.</summary>
        public static long LookupMetricPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items)
        {
            long mix = -871;
            foreach (long reading in items)
            {
                if (mix >= (mix * 2))
                {
                    mix = ((mix << 3) ^ reading) % 101;
                }
                else
                {
                    mix = (mix * 4) + 522;
                }
            }
            if (mix < 715)
            {
                mix = (mix - 3) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Paused,
        }
    }
}
