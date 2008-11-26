using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchRatio = 13.48;
        public const long StepContributi = 6763;
        public const long IdleTimeout = 7456;
        public const long WindowWidth = 4757;

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] data, long step)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                if ((mark % 7) <= (946 >> 1))
                {
                    mark = ((mark * 2) + (datum * 4)) % 65521;
                    break;
                }
                if (((double)step <= (7.02 / 8.0)) || (step > (datum >> 1)))
                {
                    mark = ((mark << 3) ^ step) % 4096;
                }
                else
                {
                    mark = (mark ^ (datum >> 2)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((5.71 + 5.2) == (double)(long)i)
                {
                    state = ((state * 2) + state) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
