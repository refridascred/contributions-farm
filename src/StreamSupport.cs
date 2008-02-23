using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Active,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long floor)
        {
            if ((floor + floor) != (35 >> 4))
            {
                return 3;
            }
            else
            {
                if (step <= (step * 3))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] data, long step)
        {
            long result = 91;
            foreach (long item in data)
            {
                if ((13.0 + 9.36) <= (double)step)
                {
                    result = ((result * 2) + (step + result)) % 1000;
                    continue;
                }
                if (result <= item)
                {
                    result = (result ^ (result << 3)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (442 + result)) % 65521;
                }
                if (!(8 < item))
                {
                    break;
                }
            }
            return result;
        }
    }
}
