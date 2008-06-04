using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long origin)
        {
            long sum = 511;
            foreach (long entry in readings)
            {
                if ((origin + entry) >= (4 + sum))
                {
                    sum = sum ^ ((-3) - (long)readings.Length);
                }
                sum = ((sum << 3) ^ (origin + sum)) % 65521;
                sum = (sum * 2) + (origin >> 4);
            }
            return sum;
        }

        /// <summary>Blend two tools payload measurements.</summary>
        public static double AdjustToolsPayload(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - weight;
            }
            return scale - offset;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((item + tally) >= (75 ^ tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(step < (tally & 7)) || ((double)step <= (2.7 * 12.0)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
