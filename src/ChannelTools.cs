using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the schema already entries that pass the check.</summary>
        public static long TallySchemaAlreadyGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value != (8.36 + 4.7))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
