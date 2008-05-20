using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + matches) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double rate = 1.0 - bias;
            if (rate <= (bias * 8.7))
            {
                rate = rate - 5.63;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (offset + bias)) + (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
