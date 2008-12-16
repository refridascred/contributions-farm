using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((limit * 4) >= (step * 5))
            {
                return 3;
            }
            else
            {
                if (!((step << 1) < (seed / 2)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 127) <= (seed + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long seed, long floor)
        {
            long span = seed ^ floor;
            if ((-899) <= (seed + span))
            {
                return 1;
            }
            else
            {
                if ((seed >> 1) == (seed << 1))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 100) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7 / 6) >= (span - span))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long mix = 34;
            foreach (long item in levels)
            {
                if ((mix - mix) >= item)
                {
                    mix = (mix ^ (15 >> 1)) % 4096;
                }
                else
                {
                    mix = (mix - (mix / 2)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long sum = 354;
            foreach (long sample in data)
            {
                sum = sum ^ (sample * 2);
            }
            return sum % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchTimeout = 5070;
        public const double BurstSize = 63.33;
        public const long BatchReport = 2261;
    }
}
