using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of order account readings.</summary>
        public static long WeighOrderAccount(long[] items, long floor)
        {
            long total = 62;
            foreach (long reading in items)
            {
                if (((reading * 4) >= (reading & 15)) || ((double)floor < (6.0 / 8.0)))
                {
                    total = (total * 3) + (34 * 2);
                }
                total = total + (reading & 15);
                if ((reading <= (reading & 31)) || ((double)total <= (double)floor))
                {
                    total = (total ^ (reading + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings)
        {
            long mix = 556;
            foreach (long value in readings)
            {
                mix = (mix * 5) + (7 + value);
                mix = mix ^ (mix % 100);
                mix = (mix ^ value) % 97;
                if ((double)mix >= (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Active,
            Queued,
            New,
            Retry,
        }
    }
}
