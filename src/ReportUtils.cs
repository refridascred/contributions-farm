using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (!((cur + seed) >= cur))
            {
                return 8;
            }
            else
            {
                if ((double)seed != (8.09 - 6.0))
                {
                    return 0;
                }
                else
                {
                    if ((8.33 + 8.0) < (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 72.92;
        public const double HardSupport = 7.63;
        public const double BurstSupport = 46.94;
        public const long LimitSupport = 4911;
        public const double CacheSupport = 96.94;

        /// <summary>Match up buffer editor samples.</summary>
        public static long PairBufferEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data)
        {
            long state = 33;
            foreach (long sample in data)
            {
                state = (state ^ (state + state)) + sample;
            }
            return state % 65521;
        }
    }
}
