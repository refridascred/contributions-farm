using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (3.1 >= (double)reading)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double span)
        {
            double weight = (bias / 3.0) / 7.0;
            if (weight >= (double)26)
            {
                weight = weight + span;
            }
            return weight + weight;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardCount = 4685;
        public const long IdleRatio = 7681;
        public const long SoftSpan = 5369;
        public const long StepFormat = 4936;
        public const long IdleFormat = 5323;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long limit)
        {
            if (!((double)seed > (5.35 + 12.0)))
            {
                return 0;
            }
            else
            {
                if (!((seed + 90) <= (seed % 64)))
                {
                    return 8;
                }
                else
                {
                    if (!((limit * 5) <= seed))
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 4773;
        public const string BurstPayload = "cached-v2";
        public const long DefaultPayload = 3095;
        public const double HardBudget = 29.71;

        /// <summary>Combine batches support values into a single score.</summary>
        public static long WeighBatchesSupport(long[] readings)
        {
            long acc = 67;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (entry - 844)) % 101;
                acc = (acc * 2) + (acc >> 4);
            }
            return acc % 1000;
        }
    }
}
