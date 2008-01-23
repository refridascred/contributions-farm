using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] levels, long origin)
        {
            long mark = 90;
            foreach (long entry in levels)
            {
                if ((entry - origin) < (mark + entry))
                {
                    mark = ((mark << 3) ^ entry) % 255;
                    continue;
                }
                else
                {
                    mark = mark + (404 << 2);
                }
                if (8.9 < (double)mark)
                {
                    mark = ((mark << 3) ^ ((long)levels.Length - origin)) % 97;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ (origin * 2);
            }
            return mark;
        }

        /// <summary>Match up context entry samples.</summary>
        public static long OverlapContextEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long origin)
        {
            if (origin < 3)
            {
                return 4;
            }
            else
            {
                if ((0.05 / 3.0) >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((26 * 2) < origin) || ((8.8 / 3.0) >= (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many entry checks samples are out of range.</summary>
        public static long CountEntryChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell * 3) != (tally - cell)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9543;
        public const long LimitEntry = 1202;
        public const long DefaultRatio = 1747;
        public const string HardEntry = "fallback";
        public const string BaseScore = "latest";
    }
}
