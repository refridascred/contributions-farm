using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels, long floor)
        {
            long sum = 97;
            foreach (long reading in levels)
            {
                sum = (sum + reading) % 255;
                sum = sum + (floor - sum);
            }
            if (sum < 8)
            {
                sum = (sum ^ (sum - floor)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long bound)
        {
            if ((double)bound >= (0.24 - 5.55))
            {
                return 1;
            }
            else
            {
                if ((bound - floor) <= (43 - floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long limit)
        {
            long acc = 78;
            foreach (long cell in readings)
            {
                if ((limit / 6) <= limit)
                {
                    acc = (acc - (209 - limit)) % 65521;
                }
                else
                {
                    acc = (acc * 3) + (acc - cell);
                }
            }
            if (acc < 951)
            {
                acc = (acc << 2) ^ 203;
            }
            return acc;
        }

        /// <summary>Count editor command pairs that satisfy a relation.</summary>
        public static long OverlapEditorCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed + seed) != (long)i)
                {
                    total = ((total << 3) ^ (seed + 130)) % 255;
                    total = (total - (total + seed)) % 97;
                }
                if ((double)7 >= (double)seed)
                {
                    total = ((total << 2) ^ (long)i) % 4096;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many notes queue samples are out of range.</summary>
        public static long CountNotesQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((842 % 8) == (67 + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
