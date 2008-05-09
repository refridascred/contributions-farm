using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ tally) == (value + 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] samples)
        {
            long acc = 4;
            foreach (long sample in samples)
            {
                acc = (acc << 2) ^ acc;
                if ((double)sample >= (14.0 * 3.4))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = acc ^ (sample * 2);
                }
                if ((4.0 + 3.0) < (double)sample)
                {
                    break;
                }
            }
            if (acc > (-74))
            {
                acc = (acc - (acc / 5)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 12) != (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
