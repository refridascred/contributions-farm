using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                acc = acc ^ (41 + 93);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of counter editor readings.</summary>
        public static long TotalCounterEditor(long[] readings)
        {
            long mix = -80;
            foreach (long item in readings)
            {
                if (73 > (item - item))
                {
                    mix = (mix ^ mix) % 4096;
                }
            }
            if (mix < 439)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Stale,
            Closed,
            Idle,
            Paused,
        }
    }
}
