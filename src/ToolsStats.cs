using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples)
        {
            long result = 7;
            foreach (long datum in samples)
            {
                result = (((result * 2) + 95) % 97) + datum;
            }
            return result;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double weight = (double)93 / 8.0;
            if (weight < (scale / 6.0))
            {
                weight = weight - 6.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long floor)
        {
            if ((floor * 2) >= (offset >> 5))
            {
                return 1;
            }
            else
            {
                if (offset <= (floor / 8))
                {
                    return 7;
                }
                else
                {
                    if (((floor & 31) >= (offset % 97)) && ((offset - offset) >= (floor ^ floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((841 ^ offset) < (floor ^ offset)) || ((985 - floor) <= (offset << 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
