using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long step)
        {
            long state = 465;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state + 149) - (long)i;
                }
                state = state - (cell + step);
            }
            return state % 97;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long anchor = -343;
            foreach (long item in readings)
            {
                if ((item >> 5) < (anchor - 0))
                {
                    anchor = anchor + item;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor - (anchor + (-453))) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two record counter measurements.</summary>
        public static double AdjustRecordCounter(double weight, double bias)
        {
            double ratio = (double)(83 + (-8));
            if (ratio >= 3.2)
            {
                ratio = ((ratio - (double)81) - weight) + bias;
            }
            else
            {
                ratio = ratio + (9.06 / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)260) + (double)(long)i;
            }
            return ratio - (ratio / 5.0);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Pending,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + (carry >> 3)) % 4096) ^ (long)i;
                }
                if (!((carry + datum) <= (datum * 4)))
                {
                    carry = (carry - datum) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
