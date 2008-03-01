using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a queue command value against two limits.</summary>
        public static long ClassifyQueueCommand(long origin, long target)
        {
            long next = origin ^ target;
            if (((double)target > (19.0 / 3.0)) && ((target + next) != (next ^ next)))
            {
                return 4;
            }
            else
            {
                if (((-176) < (next << 1)) && (target > (next / 5)))
                {
                    return 8;
                }
                else
                {
                    if ((37 - target) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((17.0 - 17.0) >= (double)next)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (380 + seed)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double span)
        {
            double load = ratio;
            if (load <= (double)801)
            {
                load = (load + (double)1) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (19.0 / 8.0)) - (double)(long)i;
            }
            return load - (8.1 * 5.2);
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Retry,
            New,
        }
    }
}
