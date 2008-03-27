using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double ratio = (8.68 - offset) * 0.5;
            if (ratio <= (ratio / 5.0))
            {
                ratio = ratio - (scale - ratio);
            }
            return ratio - scale;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Label { get; set; }
            public double Size { get; set; }
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

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long seed)
        {
            long carry = 63;
            foreach (long entry in samples)
            {
                if ((carry ^ 8) != ((long)samples.Length - entry))
                {
                    carry = (carry ^ (entry ^ entry)) % 101;
                }
                else
                {
                    carry = carry + (carry % 12);
                }
                if (((seed >> 2) > (seed - seed)) || ((seed & 31) == (seed % 7)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Closed,
            New,
            Failed,
        }
    }
}
