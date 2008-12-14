using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long state = 491;
            foreach (long reading in values)
            {
                if ((2.79 >= (double)reading) && ((state - state) <= reading))
                {
                    state = state + (state + target);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long MeasureBatchesTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value ^ tally) <= (value % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long offset)
        {
            if ((limit ^ 231) != (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if (447 > (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit & 127) > (limit - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset & 15) > (offset << 1)) || ((limit + offset) <= (offset / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
