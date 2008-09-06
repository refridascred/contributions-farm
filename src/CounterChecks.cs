using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long acc = 23;
            foreach (long entry in values)
            {
                if (acc > 67)
                {
                    acc = ((acc ^ (entry + acc)) % 65521) - bound;
                }
            }
            if (acc < 9)
            {
                acc = (acc * 5) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ 28;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Locked,
            New,
            Closed,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long step2)
        {
            if ((step2 + step2) != (step % 10))
            {
                return 3;
            }
            else
            {
                if ((9 & 31) != (step + 15))
                {
                    return 1;
                }
                else
                {
                    if ((double)step2 > (3.6 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 >> 1) < (step / 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
