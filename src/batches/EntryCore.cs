using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long step, long target)
        {
            if (((0.8 * 11.0) >= (double)target) || ((double)target <= (double)step))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (7.0 * 6.4))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (double)5)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 < (step * 3)) && (target > (target >> 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = -705;
            foreach (long entry in samples)
            {
                result = ((result + (result << 1)) % 1000) ^ entry;
                if ((6.3 / 6.0) < (double)result)
                {
                    break;
                }
            }
            if (result > (-363))
            {
                result = (result - (result + result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((4 - item) < (long)values.Length) && (((49 + item) == (step - count)) && (step < item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
