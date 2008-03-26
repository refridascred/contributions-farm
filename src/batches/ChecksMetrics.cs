using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a context window reading by value.</summary>
        public static long SeekContextWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long carry = 539;
            foreach (long cell in readings)
            {
                carry = carry + (cell - cell);
                carry = (carry ^ (carry / 2)) % 65521;
            }
            if (carry > 501)
            {
                carry = ((carry << 3) ^ (146 - 2)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next cache stream value.</summary>
        public static double SmoothCacheStream(double rate, double floor)
        {
            double rate2 = (double)445 * 15.0;
            if (rate2 >= floor)
            {
                rate2 = (rate2 + (double)185) - rate;
            }
            return rate2 + (double)288;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Failed,
            Dropped,
            Pending,
        }
    }
}
