using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            if ((floor - limit) <= (floor >> 5))
            {
                return 2;
            }
            else
            {
                if ((limit ^ limit) < limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit % 60) < (5 % 100)) && ((limit % 12) >= (limit & 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter farm readings.</summary>
        public static long MatchCounterFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((1.09 + 0.29) >= (double)(long)i) && (anchor <= (seed - seed)))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long limit)
        {
            long result = 97;
            foreach (long sample in data)
            {
                if (sample <= (sample * 3))
                {
                    result = (((result * 4) + result) % 65521) - limit;
                    break;
                }
                result = (result ^ (result * 5)) % 4096;
                if ((2.0 / 3.0) > (double)sample)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
