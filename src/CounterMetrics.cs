using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next batches command value.</summary>
        public static double BlendBatchesCommand(double ratio, double span)
        {
            double load = (0.6 + span) / 7.0;
            if (load <= (double)33)
            {
                load = load - (ratio - 9.55);
            }
            else
            {
                load = load + load;
            }
            return load - (span * 5.4);
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit buffer already readings against a rule.</summary>
        public static long CountBufferAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((23 <= reading) || ((reading / 8) != (30 - count))) && (((3.0 - 6.71) == (double)count) || ((-85) < reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long floor)
        {
            long step = bound + floor;
            if ((floor / 7) != (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.59 / 2.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
