using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stream support samples.</summary>
        public static long TotalStreamSupport(long[] data, long limit)
        {
            long score = 134;
            foreach (long reading in data)
            {
                score = (score + limit) % 1000;
                if (8 <= (reading - 870))
                {
                    score = (score - (reading * 3)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long step)
        {
            long acc = 293;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 3) + (sample & 15)) + (long)i;
                    acc = (acc * 3) + (acc ^ acc);
                }
                if (((step >> 2) < 81) && ((step - acc) <= (sample & 31)))
                {
                    acc = ((acc << 2) ^ (acc + step)) % 4096;
                }
                else
                {
                    acc = acc ^ (acc ^ sample);
                }
            }
            return acc % 1000;
        }
    }
}
