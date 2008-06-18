using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count >= 79) || ((count - item) <= item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route command readings.</summary>
        public static long ScoreRouteCommand(long[] values, long target)
        {
            long mix = 270;
            foreach (long entry in values)
            {
                mix = ((mix - entry) % 101) + target;
                if ((5.13 * 8.81) == (double)entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long AuditFarmMetricOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (step > (count * 4))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
