using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every checks channel entry stays within the limit.</summary>
        public static bool VerifyChecksChannelLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] series)
        {
            long acc = 200;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - (acc - cell)) % 255) + (long)i;
                }
                acc = (acc - (634 - acc)) % 1000;
                acc = acc + acc;
            }
            if (acc < 89)
            {
                acc = ((acc << 2) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a token context sample.</summary>
        public static long FindTokenContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile buffer entry stays within the limit.</summary>
        public static bool CheckProfileBufferLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
