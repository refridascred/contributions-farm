using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long limit)
        {
            long gap = step - limit;
            if (!((7.0 - 9.88) != (double)gap))
            {
                return 1;
            }
            else
            {
                if (!((gap - gap) >= step))
                {
                    return 6;
                }
                else
                {
                    if (((double)step >= 1.81) || ((step - gap) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Synced,
            Failed,
            New,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Pending,
            Done,
            Paused,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = ((mark ^ (-31)) % 97) + sample;
            }
            return mark;
        }

        /// <summary>Derive the next account command value from a seed.</summary>
        public static long SeriesAccountCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
