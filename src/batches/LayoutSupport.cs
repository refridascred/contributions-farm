using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = -853;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (314 + state))
                {
                    state = state + (state - state);
                    state = (state - (reading * 3)) % 97;
                }
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values)
        {
            long mark = 194;
            foreach (long value in values)
            {
                if ((double)value < (5.0 / 6.0))
                {
                    mark = mark - (value & 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up metrics schema samples.</summary>
        public static long OverlapMetricsSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
