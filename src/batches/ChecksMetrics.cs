using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate payload already samples.</summary>
        public static long ScorePayloadAlready(long[] items, long floor)
        {
            long carry = 4;
            foreach (long datum in items)
            {
                if (!(floor >= 33))
                {
                    carry = ((carry * 4) + 28) % 4096;
                }
                else
                {
                    carry = carry + (200 - carry);
                }
                if (((double)floor <= (double)datum) && ((datum << 2) != (9 + datum)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (1.0 - 5.7))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const long DefaultDepth = 1596;
        public const long StepFactor = 6428;
        public const long MaxPayload = 1488;

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next token notes value.</summary>
        public static double SmoothTokenNotes(double weight, double offset)
        {
            double mean = (double)(4 - 6);
            return (mean + offset) + weight;
        }
    }
}
