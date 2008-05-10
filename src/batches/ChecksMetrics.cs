using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats buffer samples.</summary>
        public static long CombineStatsBuffer(long[] samples)
        {
            long total = -50;
            foreach (long sample in samples)
            {
                total = ((total << 2) ^ total) ^ sample;
            }
            return total;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long origin)
        {
            if ((floor - origin) != (floor ^ origin))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) <= (floor / 2)) && (floor > (origin ^ origin)))
                {
                    return 8;
                }
                else
                {
                    if (((floor - 5) > origin) || ((floor - 1) <= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((921 / 6) >= (floor >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count - reading) > (count * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
