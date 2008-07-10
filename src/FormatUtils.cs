using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 3) + ((long)i / 3);
                carry = (carry ^ (223 << 3)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of route graph readings.</summary>
        public static long MatchRouteGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Closed,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Paused,
            Stale,
            New,
        }

        /// <summary>Classify a editor profile pair into a bucket.</summary>
        public static long ClassifyEditorProfile(long limit, long limit2)
        {
            if ((limit + limit2) >= (412 / 5))
            {
                return 2;
            }
            else
            {
                if ((limit2 - limit2) < limit)
                {
                    return 7;
                }
                else
                {
                    if (limit < (limit2 + limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the window counter series from a seed.</summary>
        public static long DeriveWindowCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 3) ^ (total + total)) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
