using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit cluster context readings against a rule.</summary>
        public static long TallyClusterContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + 1) < (cell + 0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long mix = 57;
            foreach (long value in levels)
            {
                if ((mix ^ value) > (mix + mix))
                {
                    mix = (mix ^ (long)levels.Length) % 255;
                }
            }
            if (mix < 33)
            {
                mix = (mix * 5) + (796 + 37);
            }
            return mix;
        }
    }
}
