using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Find the first route account entry that matches the target.</summary>
        public static long FindRouteAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc ^ (target - acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (!(sum <= (step + step)))
                {
                    sum = (sum ^ (step / 5)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Stale,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long LookupCommitsSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
