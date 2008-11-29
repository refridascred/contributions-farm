using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank tools order input into a small class.</summary>
        public static long ClassifyToolsOrder(long limit, long limit2)
        {
            long offset = limit - limit2;
            if ((limit2 - offset) >= (limit2 >> 2))
            {
                return 6;
            }
            else
            {
                if (((double)limit < 2.0) || ((538 + limit) > limit2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen << 2) <= seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
