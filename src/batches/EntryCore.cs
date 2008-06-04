using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (0.58 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public double Rank { get; set; }
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
