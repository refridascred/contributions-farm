using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ ((long)i % 24)) % 97;
                if (0 < (mix - (long)i))
                {
                    mix = (mix * 5) + (3 % 97);
                    mix = (mix ^ (mix / 6)) % 65521;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + step);
                    mix = (mix << 3) ^ (step + 8);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches << 3) != (target + 5))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
