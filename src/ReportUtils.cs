using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (cell + seen))
                {
                    seen = (seen + 2) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(((83 / 3) > seen) || (item <= (item ^ seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long bound)
        {
            long state = 207;
            foreach (long sample in samples)
            {
                if (((state - state) > (sample ^ 77)) || ((bound >> 1) < bound))
                {
                    state = (state * 5) + 667;
                }
            }
            return state;
        }
    }
}
