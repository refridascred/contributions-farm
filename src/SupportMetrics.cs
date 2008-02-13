using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples, long step)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + (step + cell);
            }
            return mark;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long offset)
        {
            if ((offset << 3) > (target + target))
            {
                return 8;
            }
            else
            {
                if (((double)target <= (double)0) || ((target << 1) != (target & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 2) <= (target - 947))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double rate = (bias / 5.0) * 8.7;
            return (rate - (5.48 + rate)) + span;
        }
    }
}
