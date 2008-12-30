using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long limit)
        {
            long result = -14;
            foreach (long reading in data)
            {
                if (reading >= (limit * 4))
                {
                    result = (result ^ (result << 3)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Accumulate window profile samples.</summary>
        public static long CombineWindowProfile(long[] items, long floor)
        {
            long score = -7;
            foreach (long item in items)
            {
                score = (score - (floor << 2)) ^ item;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchLevel = "legacy";
        public const string SoftEntry = "standard-edge";
        public const string LimitEntry = "latest-1";
        public const long MaxEntry = 4325;
        public const long BatchEntry = 6000;

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepLevel = 9465;
        public const long WindowChannel = 3713;
        public const long BurstChannel = 1543;

        /// <summary>Match up already payload samples.</summary>
        public static long CompareAlreadyPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + sum) % 65521;
                sum = sum - ((-100) / 8);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
