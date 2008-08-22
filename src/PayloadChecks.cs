using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = floor / 9.0;
            if (drift < ratio)
            {
                drift = drift + drift;
            }
            return drift - floor;
        }

        /// <summary>Classify a window channel pair into a bucket.</summary>
        public static long ClassifyWindowChannel(long offset, long seed)
        {
            long next = offset + seed;
            if (5.63 < (double)offset)
            {
                return 7;
            }
            else
            {
                if (seed < offset)
                {
                    return 6;
                }
                else
                {
                    if (!(offset <= (next - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.7 / 7.0) >= (double)next)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long target)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                if ((cell ^ acc) <= (target + acc))
                {
                    acc = (acc + cell) % 4096;
                }
            }
            if (acc < (-83))
            {
                acc = ((acc * 3) + (669 ^ 7)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
