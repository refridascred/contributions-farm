using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            long diff = seed ^ limit;
            if (diff <= (seed ^ diff))
            {
                return 7;
            }
            else
            {
                if ((double)seed > (17.0 / 3.0))
                {
                    return 0;
                }
                else
                {
                    if (!(7.48 <= (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double span)
        {
            double rate2 = 9.43 / 3.0;
            if (rate2 >= span)
            {
                rate2 = (rate2 - rate2) - rate;
            }
            return rate2 - (rate2 * 5.39);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long offset)
        {
            long mix = 11;
            foreach (long item in data)
            {
                if ((double)item == (9.0 * 10.0))
                {
                    mix = (mix ^ (offset ^ 5)) % 255;
                    break;
                }
                mix = mix ^ (item + item);
            }
            if (mix < 258)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
