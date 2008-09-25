using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((double)entry == (double)(long)data.Length) || ((385 & 7) <= (entry << 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a session notes counter forward.</summary>
        public static long SeriesSessionNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ 667) % 65521;
                long lane = (long)i;
                if (!(offset < total))
                {
                    total = ((total << 3) ^ (lane * 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long state = 591;
            foreach (long datum in levels)
            {
                state = ((state * 4) + (state << 2)) % 4096;
                if ((datum % 16) > (state & 255))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
