using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((56 - value) < (hits * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 888;
        public const long StepScore = 2561;
        public const string BurstPayload = "staging";
        public const long WindowRatio = 7715;

        /// <summary>Match up entry session samples.</summary>
        public static long MatchEntrySessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 4846;
        public const long LimitRoute = 7376;
        public const double BatchScore = 3.3;
        public const long StepRoute = 4356;
        public const string SoftBudget = "legacy-edge";

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long origin)
        {
            long acc = 682;
            foreach (long value in levels)
            {
                if ((origin - (long)levels.Length) <= (origin << 2))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = (acc << 2) ^ (value ^ acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum + (71 >> 4)) % 97) ^ (long)i2;
                }
                sum = (sum - 801) % 255;
                sum = (sum ^ (floor ^ sum)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
