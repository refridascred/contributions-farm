using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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
