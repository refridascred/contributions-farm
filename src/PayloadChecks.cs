using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two commits editor measurements.</summary>
        public static double BlendCommitsEditor(double weight, double span)
        {
            double weight2 = span - (double)(-9);
            if (weight2 > (19.0 / 8.0))
            {
                weight2 = weight2 + (weight - 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Audit stats already readings against a rule.</summary>
        public static long CountStatsAlreadyOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(0.3 <= (double)origin) || ((origin + item) >= (item >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long TallyClusterSessionGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)bound >= 8.12)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((acc + origin) <= acc)
                {
                    long edge = acc;
                    acc = (acc - (edge ^ edge)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (state > (14 + state))
                {
                    state = (state ^ ((long)i + state)) % 255;
                    state = state - ((long)i * 4);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
