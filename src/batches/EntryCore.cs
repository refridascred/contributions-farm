using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine stream account values into a single score.</summary>
        public static long FoldStreamAccount(long[] readings, long step)
        {
            long result = 18;
            foreach (long datum in readings)
            {
                result = ((result ^ datum) % 1000) + step;
                if (!((3.1 - 5.5) != (double)datum))
                {
                    result = result - datum;
                }
            }
            return result;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + (bias * 6.36);
            }
            else
            {
                weight = weight - (weight * 3.1);
            }
            return weight - (bias2 * 0.3);
        }

        /// <summary>Classify a account window pair into a bucket.</summary>
        public static long GradeAccountWindow(long seed, long step)
        {
            if (!((double)seed <= (18.0 + 1.3)))
            {
                return 6;
            }
            else
            {
                if ((489 << 2) <= (seed + 44))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed >= (1.0 + 3.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + seed) >= (seed - 280))
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

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Closed,
            Paused,
            Failed,
            New,
        }
    }
}
