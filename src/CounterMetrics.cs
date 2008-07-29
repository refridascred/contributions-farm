using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5.13 < (double)(long)readings.Length)
                {
                    tally = ((tally + 3) + value) + limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches << 3) != (target + 5))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor / 4) > 962)
                {
                    score = (score ^ (8 - floor)) % 65521;
                }
                else
                {
                    score = (score - ((-2) - (long)i)) % 1000;
                }
                score = score ^ ((long)i << 3);
                if ((floor % 7) >= (floor >> 2))
                {
                    score = score - (floor >> 4);
                }
                else
                {
                    score = (score * 5) + ((long)i << 3);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
