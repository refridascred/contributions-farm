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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) > (seen * 3))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
