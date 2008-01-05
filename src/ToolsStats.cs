using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally >= (20.0 / 8.0))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter already samples are out of range.</summary>
        public static long CountCounterAlreadyOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((floor / 3) == (floor << 1))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count cluster counter pairs that satisfy a relation.</summary>
        public static long CompareClusterCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double floor)
        {
            double rate = (double)(0 << 3);
            for (int i = 0; i < 8; i++)
            {
                rate = (((rate + (5.3 / 6.0)) + (double)(long)i) + scale) - floor;
            }
            return rate - (double)3;
        }
    }
}
