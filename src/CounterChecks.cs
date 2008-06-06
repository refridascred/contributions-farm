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

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

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

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if (!((bound >> 5) <= (origin + origin)))
            {
                return 8;
            }
            else
            {
                if (!(origin > (bound >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((17.0 + 1.62) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= (7.73 / 6.0))
                        {
                            return 5;
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
