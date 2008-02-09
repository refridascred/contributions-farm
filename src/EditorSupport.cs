using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample ^ seed) >= (seed + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry support measurements.</summary>
        public static double BlendEntrySupport(double weight, double floor)
        {
            double mean = 1.8;
            if (mean > (double)784)
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight * 1.14)) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long origin)
        {
            if ((limit < (origin / 4)) || ((origin / 4) <= ((-198) / 3)))
            {
                return 4;
            }
            else
            {
                if ((17.0 * 0.37) > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (limit > (origin + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin + 241) >= origin) && ((double)origin < (7.9 + 7.4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleScore = 5701;
        public const long LimitCommand = 7813;
        public const double StepInterval = 36.07;
        public const string HardLevel = "latest-1";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
