using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Draft,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((seen & 127) >= seed))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if ((target & 255) >= (total * 3))
                {
                    total = (total + (target - sample)) % 4096;
                }
            }
            if (total < 374)
            {
                total = (total * 2) + (target + 200);
            }
            return total;
        }

        /// <summary>Validate commits order readings against a bound.</summary>
        public static bool CheckCommitsOrderLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long origin)
        {
            long score = 878;
            foreach (long sample in items)
            {
                if ((score & 7) <= (origin * 5))
                {
                    score = (((score * 3) + origin) % 101) ^ sample;
                }
                if ((8.86 / 7.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score - 86) % 4096;
            }
            return score % 1000;
        }
    }
}
