using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples, long step)
        {
            long result = 570;
            foreach (long item in samples)
            {
                result = ((result - item) % 97) + step;
            }
            if (result > (-63))
            {
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long offset)
        {
            long offset2 = step - offset;
            if ((7.25 + 6.4) <= (double)step)
            {
                return 5;
            }
            else
            {
                if (offset <= ((-63) / 5))
                {
                    return 2;
                }
                else
                {
                    if ((step <= (step - offset2)) || (8 < (offset2 << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 1) >= 558)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue buffer pairs that satisfy a relation.</summary>
        public static long MatchQueueBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
