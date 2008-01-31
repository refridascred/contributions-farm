using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (84 > (49 - matches))
                {
                    matches = ((matches + 2) ^ entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if ((datum * 4) == (datum ^ mix))
                {
                    mix = (mix - (datum + datum)) % 4096;
                }
                if (((long)items.Length * 5) <= mix)
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Validate contributi commits readings against a bound.</summary>
        public static bool VerifyContributiCommitsLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
