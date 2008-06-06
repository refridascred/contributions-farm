using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a schema payload reading by value.</summary>
        public static long SeekSchemaPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheFactor = 98.23;
        public const long LimitAccount = 2304;
        public const double HardAccount = 72.35;
        public const string BatchAccount = "fallback-edge";

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long CountFarmQueueHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 7) >= (count - count))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double weight = (double)(1 + 89);
            if (weight >= (rate + 7.9))
            {
                weight = weight - (bias * 16.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (bias - weight)) + (double)(long)i;
            }
            return weight - 5.8;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long target)
        {
            long diff = step ^ target;
            if ((5 + target) > (diff ^ target))
            {
                return 7;
            }
            else
            {
                if ((target ^ 54) >= target)
                {
                    return 5;
                }
                else
                {
                    if (((diff / 5) == (target + step)) || (diff <= (target & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((diff ^ target) <= 845)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
