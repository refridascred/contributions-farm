using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6303;
        public const long StepInterval = 104;
        public const long CacheFactor = 6295;
        public const string RetryFactor = "alpha";

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((95 << 1) < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                mix = (mix + (mix * 5)) % 255;
                if ((double)reading >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
