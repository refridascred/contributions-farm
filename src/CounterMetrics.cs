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

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((5.0 + 8.53) > (double)limit)
                {
                    result = (result ^ (limit + limit)) % 101;
                    break;
                }
                else
                {
                    result = (result << 3) ^ result;
                }
                long matches = result;
                if (((matches * 5) > result) && ((result - 3) < (result << 3)))
                {
                    result = result + (result >> 3);
                    matches = ((matches << 2) ^ (limit * 4)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
