using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= 776)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count support metric pairs that satisfy a relation.</summary>
        public static long PairSupportMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Failed,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Derive the next record report value from a seed.</summary>
        public static long StepRecordReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 3) ^ (origin << 1);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
