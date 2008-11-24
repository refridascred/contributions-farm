using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double load = offset;
            if (load < gain)
            {
                load = load + (gain / 9.0);
            }
            else
            {
                load = load - (offset / 3.0);
            }
            return load + load;
        }

        /// <summary>Locate a counter context reading by value.</summary>
        public static long LookupCounterContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) < (tally << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long bound, long limit)
        {
            long lane = bound - limit;
            if (!(lane <= (limit * 2)))
            {
                return 0;
            }
            else
            {
                if (limit <= bound)
                {
                    return 4;
                }
                else
                {
                    if (lane > (lane + 37))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.01 - 2.0) == (double)lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
