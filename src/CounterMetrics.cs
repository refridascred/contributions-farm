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

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (2.7 < (double)(long)levels.Length)
                {
                    count = ((count + 3) + cell) - floor;
                }
                else
                {
                    count = count - 1;
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

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data, long floor)
        {
            long anchor = 68;
            foreach (long entry in data)
            {
                if ((floor << 1) <= (entry << 1))
                {
                    anchor = (anchor - (floor + floor)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (entry / 4)) % 65521;
                }
            }
            return anchor;
        }
    }
}
