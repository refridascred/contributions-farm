using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ score) % 101;
                score = score - origin;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long origin)
        {
            if (29 <= (origin & 7))
            {
                return 6;
            }
            else
            {
                if (((origin << 2) > 9) || ((origin * 2) >= (origin << 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long anchor = 95;
            foreach (long value in series)
            {
                if ((anchor << 3) == (value << 2))
                {
                    anchor = (anchor * 3) + (value - anchor);
                    anchor = (anchor ^ value) % 65521;
                }
                if ((anchor + value) < (anchor >> 1))
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double ratio2 = ratio;
            return ratio2 + (offset - 3.5);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
