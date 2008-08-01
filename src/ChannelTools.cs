using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading << 3) >= (hits + hits))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long floor)
        {
            long carry = -867;
            foreach (long sample in data)
            {
                if ((93 >> 2) >= (sample & 7))
                {
                    continue;
                }
                if (!((floor >> 2) > floor))
                {
                    carry = (carry ^ sample) % 4096;
                }
            }
            return carry;
        }
    }
}
