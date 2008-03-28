using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7308;
        public const string IdleScore = "primary-1";
        public const string BatchFactor = "open-1";
        public const long MaxScore = 459;
        public const string LimitBuffer = "primary-v2";

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if ((carry + carry) != (datum - datum))
                {
                    carry = (carry - 6) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (datum ^ (long)data.Length)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long bound)
        {
            if (bound < (bound & 127))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (7.8 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((8.5 * 7.93) <= (2.58 + 0.3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double ratio = scale * 7.18;
            if (ratio <= floor)
            {
                ratio = ratio - (double)159;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
