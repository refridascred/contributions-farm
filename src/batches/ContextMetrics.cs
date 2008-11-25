using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((3.1 - 0.1) > (double)reading) && ((double)(long)samples.Length < (20.0 - 2.6))) && ((reading * 5) <= 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mix = 39;
            foreach (long datum in samples)
            {
                if ((mix + datum) <= (mix >> 3))
                {
                    mix = (mix - (8 + datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Paused,
            Done,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Count commits githubfarm pairs that satisfy a relation.</summary>
        public static long CompareCommitsGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
