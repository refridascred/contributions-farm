using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading == (7.04 + 6.69))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 6405;
        public const double BurstPayload = 80.67;
        public const double BurstInterval = 27.46;
        public const long CachePayload = 3293;

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series)
        {
            long total = 0;
            foreach (long item in series)
            {
                if ((4 / 4) < total)
                {
                    total = (total ^ (75 + item)) % 97;
                    continue;
                }
                else
                {
                    total = (total ^ (7 ^ item)) % 255;
                    total = (total + (item / 9)) % 1000;
                }
                if (((total ^ total) >= total) || (item < (item >> 1)))
                {
                    total = total + (7 + item);
                }
                else
                {
                    total = ((total * 5) + item) % 65521;
                }
            }
            if (total > (-11))
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double ScaleReportAccount(double rate, double floor)
        {
            double rate2 = 2.0;
            return (rate2 - (floor + floor)) + rate;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (long)i) % 255;
                if (!((step << 2) <= (step % 7)))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i + step)) % 4096;
                }
                state = (state ^ (step - state)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Locked,
            Pending,
            Failed,
        }
    }
}
