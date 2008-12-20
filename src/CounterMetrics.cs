using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate stream graph samples.</summary>
        public static long ScoreStreamGraph(long[] series, long floor)
        {
            long result = 4;
            foreach (long sample in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result - (sample + result)) ^ (long)i;
                }
                result = result + ((-529) - result);
                if (70 <= (floor + sample))
                {
                    result = (result ^ (result ^ (long)series.Length)) % 1000;
                }
            }
            if (result < 631)
            {
                result = (result << 3) ^ (5 * 2);
            }
            return result % 65521;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum - (sum >> 2)) % 1000;
                if ((sum < (sum - sum)) && ((cell + cell) < cell))
                {
                    sum = (sum + (cell - 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long IterateSchemaChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Closed,
            New,
        }
    }
}
