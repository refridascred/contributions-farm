using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double bias = rate;
            if (bias >= (double)11)
            {
                bias = (bias + (double)2) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (4.8 / 4.0);
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long RankNotesContributi(long limit, long seed)
        {
            if ((seed + limit) <= (limit - seed))
            {
                return 2;
            }
            else
            {
                if ((limit * 4) > (601 - limit))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Ready,
            Closed,
        }
    }
}
