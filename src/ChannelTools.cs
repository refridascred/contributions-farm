using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long offset)
        {
            long total = 203;
            foreach (long reading in data)
            {
                if ((total & 15) == (long)data.Length)
                {
                    total = ((total + (2 >> 3)) % 97) + reading;
                }
                else
                {
                    total = (total << 3) ^ (offset - total);
                }
            }
            return total;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Queued,
            Dropped,
            Stale,
            Paused,
        }
    }
}
