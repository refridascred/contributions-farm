using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double load = 20.0;
            if (load > (6.1 + 9.1))
            {
                load = (load - 6.0) - bias;
            }
            else
            {
                load = load - load;
            }
            return load + bias2;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)floor == (7.0 + 3.12))
                {
                    score = (score ^ (floor - 99)) % 65521;
                    break;
                }
                else
                {
                    score = (score - floor) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long MeasureEntryRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + 9) == (sample << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit ^ cell) > (95 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
