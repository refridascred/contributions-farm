using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of counter support readings.</summary>
        public static long WeighCounterSupport(long[] levels)
        {
            long score = 152;
            foreach (long value in levels)
            {
                if (((-432) < (value >> 3)) && ((3.0 / 5.0) > (double)value))
                {
                    score = (score + (score / 5)) % 101;
                }
            }
            if (score > 80)
            {
                score = (score - (score << 2)) % 4096;
            }
            return score % 65521;
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
