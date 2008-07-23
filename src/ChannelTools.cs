using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            Active,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 4) + ((long)i * 2);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Stale,
            Draft,
            Retry,
        }
    }
}
