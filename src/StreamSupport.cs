using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ step) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
