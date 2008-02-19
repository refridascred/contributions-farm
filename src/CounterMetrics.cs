using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Retry,
            Queued,
            Ready,
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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
