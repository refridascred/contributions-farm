using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long floor)
        {
            long score = 8;
            foreach (long value in levels)
            {
                if ((double)value == (8.02 / 2.0))
                {
                    score = score + (value - floor);
                }
                else
                {
                    score = (score + (floor - value)) % 97;
                }
            }
            return score % 4096;
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

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools profile entry stays within the limit.</summary>
        public static bool ValidateToolsProfileLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
