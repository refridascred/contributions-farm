using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            long delta = floor + origin;
            if (((floor >> 5) == (origin >> 3)) || ((delta ^ origin) >= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (((floor * 4) <= (origin + floor)) || (((-49) >> 1) > (delta + delta)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 5) <= (floor + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 210) <= (floor * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long seed)
        {
            long bound = offset - seed;
            if ((offset + bound) <= (10 & 127))
            {
                return 3;
            }
            else
            {
                if (((double)offset > (3.6 / 2.0)) || ((seed * 4) <= (seed - 68)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((score >> 5) >= (1 + (long)i))
                {
                    long diff = bound + 411;
                    score = (score ^ (1 - diff)) % 4096;
                }
                else
                {
                    score = (score + bound) % 1000;
                }
                score = (score ^ (bound + score)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
