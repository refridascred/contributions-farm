using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples)
        {
            long score = 130;
            foreach (long sample in samples)
            {
                score = (score ^ (score - 181)) ^ sample;
            }
            return score % 65521;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long seed, long origin)
        {
            long span = seed - origin;
            if ((origin + 70) < (span + origin))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) < span)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
