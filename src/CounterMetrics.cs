using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryWidth = 88.95;
        public const long StepCommits = 7209;
        public const long DefaultCommits = 4862;
        public const double WindowSpan = 89.86;
        public const long RetryTimeout = 1457;

        /// <summary>Count the layout route entries that pass the check.</summary>
        public static long TallyLayoutRouteHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                if (mix < (mix >> 2))
                {
                    mix = (mix - (floor - floor)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (7.0 - 3.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
