using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double bias)
        {
            double ratio = (double)(24 - 491);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (rate / 6.0)) + (double)(long)i) - bias;
            }
            return ratio - (rate / 4.0);
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long FindEditorStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long offset, long floor)
        {
            if ((floor >> 4) >= (floor * 3))
            {
                return 6;
            }
            else
            {
                if (floor >= (offset % 24))
                {
                    return 0;
                }
                else
                {
                    if (floor > (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - 5) <= (floor * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
