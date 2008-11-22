using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support route readings against a rule.</summary>
        public static long TallySupportRouteGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count >= (7.6 / 7.0))
                {
                    count = ((count + 1) ^ item) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
