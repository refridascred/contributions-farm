using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of support profile readings.</summary>
        public static long FoldSupportProfile(long[] values)
        {
            long state = 72;
            foreach (long sample in values)
            {
                if ((state - sample) > 2)
                {
                    state = (state + (6 + sample)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > 15.0)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long step)
        {
            if ((4.66 - 2.0) >= (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)seed == (12.0 - 0.2)) && (step <= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    if (!((seed * 4) > step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 1164;
        public const long RetryBatches = 4099;
        public const double CacheWidth = 49.98;
        public const long BaseBatches = 2347;

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels)
        {
            long result = 332;
            foreach (long datum in levels)
            {
                if ((result << 1) <= (result + result))
                {
                    result = (result ^ (datum + 325)) % 255;
                }
                if ((result + datum) > datum)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
