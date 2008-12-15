using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two session metrics measurements.</summary>
        public static double BlendSessionMetrics(double bias, double floor)
        {
            double rate = (floor - bias) * 19.0;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate - (double)73;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if (3 < (state >> 4))
                {
                    long diff = 39;
                    state = ((state << 2) ^ diff) % 65521;
                }
                else
                {
                    long seen = (target ^ target) + (target >> 2);
                    state = state ^ (seen + seen);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
