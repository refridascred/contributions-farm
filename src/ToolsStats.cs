using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((seen + seen) <= (seen + (-467))))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long floor, long origin)
        {
            long prev = floor ^ origin;
            if ((floor + 85) <= (prev * 2))
            {
                return 8;
            }
            else
            {
                if (origin < (floor - prev))
                {
                    return 6;
                }
                else
                {
                    if (origin > (-16))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin + floor) >= (prev + prev)) && ((-42) > (prev * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long offset)
        {
            if ((19.0 * 8.0) != (double)offset)
            {
                return 0;
            }
            else
            {
                if (((offset - step) < offset) && ((double)offset >= 3.95))
                {
                    return 7;
                }
                else
                {
                    if (((785 - step) == (1 * 4)) || ((offset - offset) < (0 + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - offset) >= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double rate = (bias + bias) / 7.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (0.1 + weight)) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Idle,
            Draft,
            Queued,
            Done,
        }
    }
}
