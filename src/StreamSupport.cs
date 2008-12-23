using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Draft,
            Queued,
            Paused,
            New,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (score << 1)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5 << 1) == (limit ^ limit))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
