using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if (floor > 8)
            {
                return 7;
            }
            else
            {
                if ((floor - offset) != (floor - 17))
                {
                    return 4;
                }
                else
                {
                    if (offset >= (offset % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset & 15) > (floor / 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample > (tally + sample))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = (state + target) % 65521;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 2) + 7) % 4096) ^ (long)i2;
                }
                state = (state + (state * 5)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long TotalChannelSchema(long[] levels, long floor)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = ((score + (score ^ score)) + entry) + floor;
            }
            return score;
        }
    }
}
