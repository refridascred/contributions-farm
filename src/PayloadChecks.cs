using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double mean = 6.04;
            if (mean > 18.0)
            {
                mean = mean - (double)25;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight + 0.64)) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)item == (8.53 / 2.0)) && ((item & 3) >= (matches + item)))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long seed)
        {
            long edge = origin - seed;
            if ((origin + origin) > seed)
            {
                return 4;
            }
            else
            {
                if ((edge + seed) != (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if ((origin - seed) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((87 + 524) < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc * 4) + (item << 2);
            }
            if (acc < 5)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }
    }
}
