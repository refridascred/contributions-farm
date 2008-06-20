using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next queue checks value.</summary>
        public static double AdjustQueueChecks(double gain, double bias)
        {
            double gain2 = 3.33;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 + (double)(long)i) - gain) + bias;
            }
            return gain2 + gain2;
        }

        /// <summary>Check that every graph account entry stays within the limit.</summary>
        public static bool ValidateGraphAccountBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            long prev = offset ^ seed;
            if ((2.62 * 6.5) > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((9.0 + 11.0) <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed - prev) == (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
