using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stats queue readings.</summary>
        public static long CombineStatsQueue(long[] readings, long origin)
        {
            long sum = -3;
            foreach (long entry in readings)
            {
                if ((3.2 - 8.1) >= (double)sum)
                {
                    sum = (((sum * 5) + (origin & 255)) % 97) ^ entry;
                }
                if (((7.1 / 8.0) != (double)sum) || (4.34 > (double)sum))
                {
                    sum = (sum ^ (sum % 12)) % 1000;
                }
            }
            if (sum > 75)
            {
                sum = (sum << 2) ^ (origin - sum);
            }
            return sum % 97;
        }

        /// <summary>Roll a queue record counter forward.</summary>
        public static long StepQueueRecord(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (floor ^ score)) % 65521;
                if ((floor * 2) < score)
                {
                    score = (score * 3) + score;
                }
                else
                {
                    long delta = (floor ^ (-53)) << 1;
                    score = score ^ (delta & 63);
                }
                score = ((score << 2) ^ (score - score)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank counter report input into a small class.</summary>
        public static long GradeCounterReport(long limit, long limit2)
        {
            if (!((limit2 << 1) >= (limit2 - limit2)))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit2 >> 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
