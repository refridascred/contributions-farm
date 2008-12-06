using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (13.0 * 3.3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Locked,
            Idle,
        }
    }
}
