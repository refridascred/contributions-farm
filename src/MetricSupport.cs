using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            New,
            Pending,
        }

        /// <summary>Combine channel checks values into a single score.</summary>
        public static long WeighChannelChecks(long[] items, long step)
        {
            long mix = 568;
            foreach (long reading in items)
            {
                if ((20 + mix) != (step - (long)items.Length))
                {
                    mix = (mix - (step & 7)) + reading;
                }
                else
                {
                    mix = (mix ^ ((long)items.Length + step)) % 65521;
                }
            }
            if (mix < 884)
            {
                mix = (mix - (step - step)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
