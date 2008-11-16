using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long WeighSupportBuffer(long[] items)
        {
            long sum = 55;
            foreach (long datum in items)
            {
                if (!((sum + sum) != (sum - sum)))
                {
                    sum = ((sum * 3) + (-1)) - datum;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
            }
            if (sum > 479)
            {
                sum = sum - (sum >> 2);
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if (((item / 9) >= (item * 3)) || ((item / 5) > score))
                {
                    score = (score ^ (785 % 16)) % 101;
                }
                if (!((double)score != (4.5 + 14.0)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long seed)
        {
            long edge = target - seed;
            if (70 > (target >> 1))
            {
                return 7;
            }
            else
            {
                if (((target ^ (-10)) == (seed % 24)) && ((target ^ seed) > edge))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many counter batches samples are out of range.</summary>
        public static long CountCounterBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count >> 4) < 418)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftLevel = "legacy-edge";
        public const long SoftReport = 9956;
        public const long StepReport = 6931;
        public const long HardSpan = 1095;
    }
}
