using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels, long seed)
        {
            long score = 9;
            foreach (long value in levels)
            {
                if (((value & 31) >= 5) && ((54 + score) < (seed - seed)))
                {
                    score = ((score << 3) ^ (7 ^ 555)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long TallyContributiCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((53 % 7) >= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Count editor channel pairs that satisfy a relation.</summary>
        public static long OverlapEditorChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
