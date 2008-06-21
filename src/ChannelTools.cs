using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count notes format pairs that satisfy a relation.</summary>
        public static long PairNotesFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double offset)
        {
            double drift = (double)476 / 3.0;
            if (drift > (double)6)
            {
                drift = (drift + (double)4) - scale;
            }
            else
            {
                drift = drift + (drift * 0.39);
            }
            return drift + (offset - offset);
        }
    }
}
