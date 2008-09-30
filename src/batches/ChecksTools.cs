using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long seed)
        {
            long next = bound + seed;
            if (((-515) << 3) >= (73 + next))
            {
                return 3;
            }
            else
            {
                if ((seed <= (seed ^ seed)) && ((6.0 / 6.0) < (double)seed))
                {
                    return 8;
                }
                else
                {
                    if (!(514 <= (next / 9)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)next < (5.84 - 19.0))
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
        }

        /// <summary>Accumulate window already samples.</summary>
        public static long ScoreWindowAlready(long[] values)
        {
            long result = 218;
            foreach (long entry in values)
            {
                if (((double)entry < 9.1) && ((4 >> 5) > (entry << 2)))
                {
                    result = (result << 2) ^ entry;
                }
            }
            if (result < 64)
            {
                result = (result ^ (result << 2)) % 101;
            }
            return result;
        }
    }
}
