using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleBudget = "primary-1";
        public const double StepFilter = 24.28;
        public const long BatchInterval = 9122;
        public const long WindowFilter = 9976;
        public const string LimitFilter = "open-1";

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 3) ^ (step + step);
                mark = mark - (step << 2);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long origin)
        {
            if ((origin + origin) > 2)
            {
                return 0;
            }
            else
            {
                if (!(origin <= (bound * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (1.32 + 6.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (7.3 + 9.6)) || (origin < (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "strict-1";
        public const string SoftSchema = "legacy-edge";
        public const long DefaultSchema = 6429;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
