using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length > (4.0 - 2.2))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit buffer already readings against a rule.</summary>
        public static long CountBufferAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((23 <= reading) || ((reading / 8) != (30 - count))) && (((3.0 - 6.71) == (double)count) || ((-85) < reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long floor)
        {
            long step = bound + floor;
            if ((floor / 7) != (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.59 / 2.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
