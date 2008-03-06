using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate githubfarm payload samples.</summary>
        public static long TotalGithubfarmPayload(long[] readings, long step)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                result = ((result ^ (10 % 2)) + reading) - step;
            }
            return result;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) != (713 >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
