using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = 755;
            foreach (long sample in values)
            {
                score = (score ^ sample) % 101;
            }
            return score;
        }

        /// <summary>Blend two schema editor measurements.</summary>
        public static double ScaleSchemaEditor(double scale, double floor)
        {
            double load = scale / 5.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)49) - (double)(long)i) - floor;
            }
            return load - scale;
        }

        /// <summary>Iterate the tools cluster series from a seed.</summary>
        public static long RollToolsCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (mark + (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many command stats samples are out of range.</summary>
        public static long MeasureCommandStatsGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally % 8) >= tally)
                {
                    tally = ((tally + 3) + cell) + target;
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
