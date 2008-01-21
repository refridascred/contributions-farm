using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items, long step)
        {
            long score = 32;
            foreach (long reading in items)
            {
                score = (score + (score + (long)items.Length)) - step;
                score = (score - (reading ^ 68)) % 101;
            }
            return score;
        }

        /// <summary>Find the first record context entry that matches the target.</summary>
        public static long LocateRecordContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + target) != (matches - 8))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
