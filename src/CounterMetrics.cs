using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + seen) >= (seen - entry))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools command readings.</summary>
        public static long CompareToolsCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long step)
        {
            long cur = limit ^ step;
            if ((limit & 127) < limit)
            {
                return 1;
            }
            else
            {
                if ((double)cur > (7.77 * 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((step - (-53)) != (step % 10))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (9.3 / 8.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
