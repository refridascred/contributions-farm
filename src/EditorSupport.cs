using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long limit, long origin)
        {
            long lane = limit + origin;
            if (limit >= lane)
            {
                return 8;
            }
            else
            {
                if (lane > (limit ^ 748))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + count) >= (seed + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] levels)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = (((state * 2) + ((-540) + state)) % 255) + item;
                state = ((state * 4) + 59) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
