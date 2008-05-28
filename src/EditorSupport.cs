using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 5) + (bound >> 5);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] samples, long target)
        {
            long sum = 631;
            foreach (long cell in samples)
            {
                sum = ((sum - (cell - cell)) % 4096) - target;
                if (((3.9 * 6.12) < (double)sum) && ((double)cell < 3.03))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 72.61;
        public const long StepTimeout = 6681;
        public const long HardBudget = 9433;

        /// <summary>Audit command farm readings against a rule.</summary>
        public static long AuditCommandFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally > (6 & 63))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double weight = (double)951 / 8.0;
            if (weight <= (bias - bias))
            {
                weight = (weight + (bias + weight)) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (15.0 * 2.03)) + (double)(long)i;
            }
            return weight + (double)22;
        }
    }
}
