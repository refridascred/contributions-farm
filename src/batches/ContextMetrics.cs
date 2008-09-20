using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long offset2)
        {
            if (((offset / 2) <= (offset2 % 100)) && (offset <= (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (!(((-566) >> 4) != (offset / 5)))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 % 8) <= offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] values)
        {
            long sum = 386;
            foreach (long item in values)
            {
                long diff = item;
                sum = sum + (diff - sum);
                if ((double)sum < 6.0)
                {
                    sum = (sum + 93) % 101;
                }
            }
            if (sum > (-183))
            {
                sum = sum ^ (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Ready,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long DeriveGraphFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = result - (offset - offset);
                result = (result ^ (offset >> 2)) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
