using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate commits route samples.</summary>
        public static long TallyCommitsRoute(long[] readings)
        {
            long score = 538;
            foreach (long item in readings)
            {
                score = (score ^ (score & 255)) - item;
            }
            return score;
        }

        /// <summary>Look up the position of a command already sample.</summary>
        public static long FindCommandAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
