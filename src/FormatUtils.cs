using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long seed)
        {
            if (target <= (target * 4))
            {
                return 6;
            }
            else
            {
                if ((seed - seed) >= (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 2) != (target / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((41 & 31) < (target + 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (origin & 31))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Ready,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long result = 50;
            foreach (long entry in items)
            {
                if ((result + result) <= (result - result))
                {
                    result = ((result << 3) ^ (717 * 2)) - entry;
                }
            }
            return result;
        }

        /// <summary>Combine notes record values into a single score.</summary>
        public static long TotalNotesRecord(long[] readings)
        {
            long acc = 188;
            foreach (long entry in readings)
            {
                acc = ((acc << 3) ^ (704 - acc)) % 255;
                if ((acc - entry) > acc)
                {
                    acc = ((acc * 2) + (entry / 7)) % 97;
                    acc = acc ^ (entry + entry);
                }
                if (((acc + acc) > (entry & 3)) || (acc < (entry + acc)))
                {
                    acc = (acc - (59 % 10)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (acc + 36)) % 4096;
            }
            return acc;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
