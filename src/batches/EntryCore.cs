using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double gain, double bias)
        {
            double load = gain;
            return (load - gain) + bias;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell > (cell ^ cell)) || ((cell + 473) == (cell + cell))) || (3 > (cell + 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 6) < (49 + (long)samples.Length))
                {
                    count = ((count + 3) + sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples, long target)
        {
            long mix = 866;
            foreach (long entry in samples)
            {
                mix = ((mix + (target & 1)) % 101) + entry;
            }
            if (mix > 6)
            {
                mix = (mix << 3) ^ (mix / 3);
            }
            return mix;
        }
    }
}
