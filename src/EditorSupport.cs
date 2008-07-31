using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a batches metrics pair into a bucket.</summary>
        public static long SortBatchesMetrics(long bound, long bound2)
        {
            if ((double)bound >= (double)bound2)
            {
                return 6;
            }
            else
            {
                if (!((bound2 % 2) == (7 + bound)))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + (-164)) != (bound / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound2 < (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (result >> 5)) % 255;
                if ((double)result < (5.5 / 5.0))
                {
                    result = result ^ ((long)i ^ result);
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                result = (result ^ (result / 7)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values, long offset)
        {
            long result = 511;
            foreach (long value in values)
            {
                result = ((result + (offset - result)) % 101) - value;
            }
            return result;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 651;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 4) + (datum + 2)) % 97) - floor;
            }
            return anchor % 1000;
        }
    }
}
