using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] levels, long target)
        {
            long result = 98;
            foreach (long cell in levels)
            {
                if ((double)target < (double)result)
                {
                    result = ((result * 3) + cell) % 255;
                }
                else
                {
                    result = (result - (target + target)) % 255;
                }
            }
            return result % 1000;
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
