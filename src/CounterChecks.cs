using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long seed)
        {
            if (seed >= 1)
            {
                return 4;
            }
            else
            {
                if ((seed << 2) == (3 >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor & 15) != (seed * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((88 % 97) < (seed + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double bias)
        {
            double ratio = bias * 0.88;
            if (ratio <= (double)2)
            {
                ratio = ratio - (scale + 7.0);
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long state = 42;
            foreach (long entry in series)
            {
                state = ((state - (74 << 1)) % 4096) + entry;
            }
            if (state < 831)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state % 1000;
        }
    }
}
