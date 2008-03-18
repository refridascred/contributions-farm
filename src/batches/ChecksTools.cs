using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long score = 930;
            foreach (long reading in readings)
            {
                if ((4.7 * 14.0) > (double)reading)
                {
                    score = (score + (12 & 63)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ seed) % 1000;
                }
            }
            if (score < 1)
            {
                score = (score * 5) + (seed % 12);
            }
            return score;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = -8;
            foreach (long entry in readings)
            {
                if (!((double)entry != (9.18 + 17.0)))
                {
                    mix = (mix + (entry ^ mix)) % 65521;
                }
                else
                {
                    mix = (mix - 60) % 1000;
                }
            }
            return mix;
        }
    }
}
