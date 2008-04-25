using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 244;
            foreach (long reading in readings)
            {
                mix = (mix * 3) + (target % 60);
                if ((reading + reading) <= (reading * 5))
                {
                    mix = (mix - ((-181) % 12)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Adjust a command counter reading.</summary>
        public static double ProjectCommandCounter(double weight, double bias)
        {
            double rate = weight - weight;
            if (rate >= (double)828)
            {
                rate = (rate - (double)(-379)) + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate - (double)436;
        }

        /// <summary>Match up layout buffer samples.</summary>
        public static long MatchLayoutBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
