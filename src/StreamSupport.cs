using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long TallyStreamFarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum % 12) == (datum + 5))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Ready,
            Closed,
            Paused,
            Done,
        }
    }
}
