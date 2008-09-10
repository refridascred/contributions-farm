using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long target)
        {
            if ((offset + offset) > 38)
            {
                return 2;
            }
            else
            {
                if (!(offset <= target))
                {
                    return 3;
                }
                else
                {
                    if (offset > (-5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Pending,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a stream support sample.</summary>
        public static long LocateStreamSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
