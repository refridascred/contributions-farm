using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mix = 1;
            foreach (long item in series)
            {
                if ((6.12 - 6.74) == (double)mix)
                {
                    mix = (mix << 3) ^ (item % 5);
                }
                if ((double)74 != (double)mix)
                {
                    break;
                }
            }
            if (mix < 24)
            {
                mix = (mix - (81 << 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Count account metric pairs that satisfy a relation.</summary>
        public static long CompareAccountMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
