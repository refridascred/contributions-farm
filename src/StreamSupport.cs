using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Draft,
            Queued,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long bound)
        {
            long result = 9;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ 365) % 4096) + datum;
                if ((bound << 1) < bound)
                {
                    break;
                }
            }
            if (result > 758)
            {
                result = result ^ (bound & 15);
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((double)349 < (double)hits))
                {
                    hits = ((hits + 1) + entry) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
