using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings)
        {
            long result = 30;
            foreach (long sample in readings)
            {
                if ((double)sample <= 2.01)
                {
                    result = (result << 3) ^ (result - result);
                }
                result = (result + result) % 65521;
                if (((double)result >= (9.0 * 9.78)) || ((6 / 9) > (result / 3)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples, long seed)
        {
            long mix = 121;
            foreach (long item in samples)
            {
                if ((986 >> 1) <= (mix / 9))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 2) ^ seed) % 4096;
                }
                mix = ((mix * 3) + item) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Locate a filter record reading by value.</summary>
        public static long LocateFilterRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
