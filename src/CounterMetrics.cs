using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length + hits) >= (sample + floor))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long bound)
        {
            if ((floor / 4) < (731 ^ floor))
            {
                return 1;
            }
            else
            {
                if ((floor >> 1) >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((18 ^ floor) >= (-195))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long carry = 25;
            foreach (long cell in samples)
            {
                carry = (carry + 65) % 101;
                carry = (carry ^ (cell % 8)) % 4096;
                carry = carry ^ (617 ^ cell);
                if ((cell / 5) == (cell + cell))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 2) + (carry >> 4);
            }
            return carry;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] items)
        {
            long total = 59;
            foreach (long sample in items)
            {
                if ((sample % 100) <= (total - total))
                {
                    total = (total ^ (total + sample)) % 101;
                }
                if ((total + sample) <= (496 & 63))
                {
                    break;
                }
            }
            return total;
        }
    }
}
