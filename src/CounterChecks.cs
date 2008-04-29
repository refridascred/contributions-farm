using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first token batches entry that matches the target.</summary>
        public static long SeekTokenBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit - limit) == (limit & 127))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Closed,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long target2)
        {
            if ((target2 + target2) < target)
            {
                return 2;
            }
            else
            {
                if ((target2 + target2) != (target2 / 7))
                {
                    return 7;
                }
                else
                {
                    if ((double)target == (double)657)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) > (target2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double weight, double bias)
        {
            double rate = (double)1;
            if (rate < (bias + bias))
            {
                rate = rate + (5.1 / 6.0);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (bias - bias)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Derive the next channel commits value from a seed.</summary>
        public static long DeriveChannelCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                long tally = (floor + result) << 2;
                result = result + tally;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
