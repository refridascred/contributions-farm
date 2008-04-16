using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long target)
        {
            long next = bound - target;
            if (19.0 < (double)target)
            {
                return 4;
            }
            else
            {
                if ((6 + bound) < (1 / 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > 1.44)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next % 12) <= (bound * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mark = -7;
            foreach (long sample in levels)
            {
                mark = ((mark * 2) + (sample / 2)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of commits notes readings.</summary>
        public static long CombineCommitsNotes(long[] items, long origin)
        {
            long total = -7;
            foreach (long value in items)
            {
                total = ((total + (value % 3)) % 1000) + origin;
                total = (total ^ (value & 15)) % 97;
            }
            return total;
        }
    }
}
