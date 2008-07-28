using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double rate = scale / 9.0;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (3.9 + scale)) + (double)(long)i) - floor;
            }
            return rate - 4.8;
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long IterateSessionSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (sum < ((long)i >> 5))
                {
                    sum = ((sum * 2) + ((long)i - sum)) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (sum * 4);
                }
                if (sum <= ((long)i << 1))
                {
                    sum = (sum * 4) + (sum & 255);
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count batches payload pairs that satisfy a relation.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheTimeout = 7589;
        public const long WindowScore = 5886;
        public const long LimitFactor = 4062;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
