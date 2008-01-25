using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((74 >> 2) < (datum / 7))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a batch channel value against two limits.</summary>
        public static long SortBatchChannel(long floor, long origin)
        {
            long prev = floor - origin;
            if ((double)floor < (17.0 + 6.5))
            {
                return 1;
            }
            else
            {
                if ((origin > (prev << 3)) || (2 < (prev - floor)))
                {
                    return 2;
                }
                else
                {
                    if ((floor - prev) > (origin >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((619 * 5) != (floor >> 5)) && ((9.0 - 8.3) < (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long AuditFilterProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (6.2 + 18.0))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
