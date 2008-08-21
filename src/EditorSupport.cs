using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long floor)
        {
            if (((9.2 / 6.0) == (double)step) && ((floor / 9) <= (floor - 32)))
            {
                return 8;
            }
            else
            {
                if ((step << 2) >= floor)
                {
                    return 2;
                }
                else
                {
                    if (!((double)floor > 1.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step < (floor >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long sum = 887;
            foreach (long item in data)
            {
                if (((origin >> 5) <= (origin % 3)) && ((double)sum < (2.15 / 4.0)))
                {
                    sum = ((sum << 2) ^ sum) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Adjust a already metric reading.</summary>
        public static double AdjustAlreadyMetric(double scale, double bias)
        {
            double scale2 = scale;
            return (scale2 - scale2) + bias;
        }
    }
}
