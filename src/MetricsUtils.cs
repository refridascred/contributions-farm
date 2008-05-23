using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 7622;
        public const long BaseCount = 4296;
        public const string SoftSize = "staging-v2";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long ClassifyClusterGraph(long floor, long target)
        {
            long step = floor ^ target;
            if (((double)target == (3.21 - 18.0)) && (30 < (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((floor + step) != (step % 60)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 91) <= (floor - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - step) <= ((-8) - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((78 + tally) < offset)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
