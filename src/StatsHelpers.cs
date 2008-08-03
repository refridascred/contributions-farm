using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of checks format entries.</summary>
        public static long WeighChecksFormat(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if ((double)datum >= 2.41)
                {
                    mix = (mix + (80 + datum)) % 4096;
                }
                else
                {
                    mix = (mix ^ (mix >> 3)) % 101;
                }
            }
            if (mix < (-8))
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long bound)
        {
            if (bound >= 722)
            {
                return 4;
            }
            else
            {
                if ((bound / 6) <= (827 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((9.0 / 7.0) != (double)step) && ((bound & 1) <= (bound % 64)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
