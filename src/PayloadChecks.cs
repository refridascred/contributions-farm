using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long floor)
        {
            long edge = step ^ floor;
            if ((edge + floor) <= (edge % 16))
            {
                return 3;
            }
            else
            {
                if (((step * 3) >= (floor + edge)) && ((step - step) != (step / 9)))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (step - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + floor) >= step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long bound)
        {
            if (((offset >> 5) >= (offset + offset)) || (374 > (offset + offset)))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (8.0 * 14.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
