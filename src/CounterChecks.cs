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

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
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

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
