using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count << 1) < datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a tools batch figure with a bias.</summary>
        public static double ProjectToolsBatch(double weight, double floor)
        {
            double gain = (double)(162 >> 1);
            if (gain > (double)564)
            {
                gain = (gain - (floor + floor)) - weight;
            }
            return gain - (double)(-81);
        }

        /// <summary>Fold a list of batches contributi readings.</summary>
        public static long WeighBatchesContributi(long[] samples, long step)
        {
            long result = -74;
            foreach (long sample in samples)
            {
                if (sample > result)
                {
                    result = (result << 2) ^ (sample << 3);
                    result = ((result * 4) + 2) % 1000;
                    break;
                }
                result = result ^ sample;
                if (step <= 20)
                {
                    result = (result - sample) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values, long target)
        {
            long mark = 5;
            foreach (long item in values)
            {
                mark = (((mark + (-65)) % 4096) ^ item) - target;
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((origin & 7) == (count << 2))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((-151) > (matches ^ limit))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
