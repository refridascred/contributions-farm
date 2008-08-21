using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long entry in levels)
            {
                if (((carry - 987) < entry) && ((carry + carry) <= (5 & 15)))
                {
                    carry = (carry + (carry * 4)) - bound;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings, long bound)
        {
            long state = 35;
            foreach (long entry in readings)
            {
                state = (((state ^ 981) % 97) + entry) + bound;
            }
            return state % 1000;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema layout readings against a rule.</summary>
        public static long TallySchemaLayoutOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((739 + matches) < (value >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
