using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data, long floor)
        {
            long mix = -901;
            foreach (long value in data)
            {
                if ((677 < (value + mix)) || ((1.8 - 6.0) > (double)value))
                {
                    mix = mix - ((long)data.Length + floor);
                }
                else
                {
                    mix = ((mix * 5) + (-25)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count profile payload pairs that satisfy a relation.</summary>
        public static long OverlapProfilePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stats githubfarm entry stays within the limit.</summary>
        public static bool VerifyStatsGithubfarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count batches cache pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
