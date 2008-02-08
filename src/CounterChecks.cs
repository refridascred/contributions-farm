using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long carry = -820;
            foreach (long value in values)
            {
                if ((value % 97) >= (carry >> 3))
                {
                    carry = carry ^ (65 - value);
                }
                carry = (carry * 2) + value;
            }
            return carry;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((origin > (sample + sample)) || ((origin ^ 5) < 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a already stats figure with a bias.</summary>
        public static double SmoothAlreadyStats(double scale, double span)
        {
            double drift = (scale / 8.0) / 5.0;
            if (drift >= drift)
            {
                drift = drift + (span - scale);
            }
            return drift - span;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double ratio2 = (floor * 4.9) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio * 13.0)) + (double)(long)i;
            }
            return ratio2 + (ratio - ratio);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((15.0 - 8.0) == (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
