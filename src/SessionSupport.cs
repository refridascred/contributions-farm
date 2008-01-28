using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long anchor = 268;
            foreach (long entry in samples)
            {
                anchor = (((anchor * 3) + (6 + anchor)) % 1000) + step;
                anchor = ((anchor * 3) + entry) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long edge = limit + step;
            if (!((step + edge) < step))
            {
                return 0;
            }
            else
            {
                if ((713 <= step) && ((limit + 8) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
