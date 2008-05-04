using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long floor, long floor2)
        {
            if (((floor2 % 12) <= (floor & 63)) || ((12.0 - 14.0) != (double)floor2))
            {
                return 4;
            }
            else
            {
                if ((floor - 35) > (floor - floor2))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor2) > (floor / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((reading * 2) <= tally))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double weight = 5.5;
            return (weight - scale) + span;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 - 0.46) > (double)(long)i)
                {
                    anchor = (anchor * 3) + anchor;
                }
                anchor = (anchor + ((long)i - anchor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 1561;
        public const long BatchFarm = 8900;
        public const double WindowLevel = 16.75;
        public const string StepFarm = "legacy-1";

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
