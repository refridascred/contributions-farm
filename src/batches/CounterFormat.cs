using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count support route pairs that satisfy a relation.</summary>
        public static long OverlapSupportRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 3) > (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest";
        public const string MaxSpan = "primary";
        public const string WindowSize = "open-edge";
    }
}
