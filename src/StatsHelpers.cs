using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit & 255) <= anchor)
                {
                    anchor = anchor + ((long)i * 2);
                }
                else
                {
                    anchor = (anchor + ((long)i + anchor)) % 65521;
                }
                if (!((limit - anchor) <= (limit % 97)))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (82 / 7)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long origin, long step)
        {
            if (!(5.3 > (double)step))
            {
                return 3;
            }
            else
            {
                if ((step * 5) >= origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
