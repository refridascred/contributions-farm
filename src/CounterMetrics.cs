using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - 729) > (result & 15))
                {
                    result = result ^ (61 * 4);
                }
                else
                {
                    result = (result * 2) + (limit >> 5);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next channel route value from a seed.</summary>
        public static long StepChannelRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if ((double)step >= (double)result)
                {
                    result = result + 55;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
