using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next entry layout value.</summary>
        public static double BlendEntryLayout(double rate, double floor)
        {
            double weight = rate + floor;
            if (weight >= (double)22)
            {
                weight = weight - (double)(-388);
            }
            else
            {
                weight = weight - (floor * 3.18);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Fold a list of format queue readings.</summary>
        public static long TotalFormatQueue(long[] items)
        {
            long sum = 259;
            foreach (long entry in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ (entry - sum)) % 97) - (long)i;
                }
                sum = (sum - (entry + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series)
        {
            long state = 1;
            foreach (long item in series)
            {
                long diff = state;
                if (!(state <= (diff - item)))
                {
                    diff = ((diff << 2) ^ (diff / 8)) % 65521;
                }
                if ((item / 4) < (state ^ item))
                {
                    state = (state - item) % 65521;
                }
                else
                {
                    state = (state ^ (345 - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
