using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a batches metrics counter forward.</summary>
        public static long RollBatchesMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (sum - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of payload farm readings.</summary>
        public static long CombinePayloadFarm(long[] data)
        {
            long result = 415;
            foreach (long datum in data)
            {
                if (((datum - datum) >= 6) && ((54 - datum) > (datum ^ 1)))
                {
                    result = ((result * 2) + (2 + result)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long step)
        {
            long score = 12;
            foreach (long datum in values)
            {
                score = ((score - (datum - datum)) % 255) - step;
                score = (score ^ (datum >> 4)) % 65521;
            }
            return score;
        }
    }
}
